
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Bettersoft.Common;
using System.Windows.Forms;

namespace Bettersoft.OpenCA.CAData
{
    public partial class CADataHelper
    {
        /// <summary>
        /// 从证书请求目录中获取证书请求对象列表
        /// </summary>
        /// <param name="openSSLFilePath">OpenSSL.exe文件路径</param>
        /// <param name="reqDir">证书请求目录（CAData/reqwait, CAData/reqreject）</param>
        /// <returns>证书请求对象列表</returns>
        public List<Request> GetRequestList(string reqDir)
        {

            var reqs = new List<Request>();
            var reqfiles = Directory.GetFiles(reqDir, "*.pem");
            foreach (var reqfile in reqfiles)
            {
                var req = this.GetRequestObj(reqfile);
                reqs.Add(req);
            }
            reqs = reqs.OrderBy(p => p.SubjectText).ToList();
            return reqs;
        }

        /// <summary>
        /// 获取证书请求文件中的信息
        /// </summary>
        /// <param name="reqFilePath">证书请求文件完整路径</param>
        /// <returns>证书请求文件中的信息</returns>
        public string GetRequestText(string reqFilePath)
        {
            reqFilePath = reqFilePath.Replace('\\', '/');
            var errorText = "";
            var arguments = " req -in " + reqFilePath + " -text -noout ";
                            //+ " -config " + this.configFilePath.Replace('\\', '/');
            var resultText = CmdHelper.Execute(this.openSSLFilePath, arguments, out errorText);
            if (errorText.Contains("error"))
            {
                var ex = new Exception(reqFilePath + Environment.NewLine + errorText);
                throw ex;
            }

            return resultText;
        }

        /// <summary>
        /// 从证书请求文件中解析出证书请求对象
        /// </summary>
        /// <param name="reqFilePath">证书请求文件完整路径</param>
        /// <returns>证书请求对象</returns>
        public Request GetRequestObj(string reqFilePath)
        {
            var certRequest = new Request();
            try
            {
                var text = this.GetRequestText(reqFilePath);
                //var lines = text.Split(Environment.NewLine.ToCharArray());
                var lines = text.Split('\n');
                foreach (var line in lines)
                {
                    var lineStr = line.Trim();
                    if (lineStr.StartsWith("Subject:"))
                        certRequest.SubjectText = lineStr.TrimStart("Subject:".ToCharArray()).Trim();
                    if (lineStr.StartsWith("Public Key Algorithm:"))
                        certRequest.PublicKeyAlgorithm = lineStr.TrimStart("Public Key Algorithm".ToCharArray()).TrimStart(':').Trim();
                    if (lineStr.StartsWith("Public-Key:"))
                        certRequest.KeyBitLength = lineStr.TrimStart("Public-Key:".ToCharArray()).Trim().TrimStart('(').TrimEnd("bit)".ToCharArray()).Trim();
                    if (lineStr.StartsWith("Signature Algorithm:"))
                        certRequest.SignatureAlgorithm = lineStr.TrimStart("Signature Algorithm:".ToCharArray()).Trim();
                    if (lineStr.StartsWith("CA:"))
                    {
                        var isCA = lineStr.TrimStart("CA:".ToCharArray()).Trim().ToUpper();
                        if (isCA == "TRUE")
                            certRequest.SubjectType = SubjectType.SubCA;
                        else
                            certRequest.SubjectType = SubjectType.User;
                    }

                    certRequest.FilePath = reqFilePath;
                }
                
                return certRequest;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// 生成证书申请文件
        /// </summary>
        /// <param name="requestObj"></param>
        public void GenRequestFile(Request requestObj)
        {
            var password = "123456";
            var reqFilePath = this.caDataDir.TrimEnd('\\') + @"\temp\req.pem";
            var keyFilePath = this.caDataDir.TrimEnd('\\') + @"\temp\key.pem";
            reqFilePath = reqFilePath.Replace('\\', '/');
            keyFilePath = keyFilePath.Replace('\\', '/');
            var errorText = "";
            var arguments = " req -new -newkey rsa:" + requestObj.KeyBitLength
                            + " -keyout " + keyFilePath + " -passout pass:" + password
                            + " -out " + reqFilePath
                            + " -subj " + requestObj.SubjectText
                            + " -batch"
                            + " -config " + this.configFilePath.Replace('\\', '/');
            switch(requestObj.SubjectType )
            { 
                case SubjectType.RootCA:                    
                    break;
                case SubjectType.SubCA:
                    arguments += " -reqexts v3_req_subca ";
                    break;
                case SubjectType.User:
                default:
                    arguments += " -reqexts v3_req_user ";
                    break;
            }
            var resultText = CmdHelper.Execute(this.openSSLFilePath, arguments, out errorText);
            if (errorText.Contains("error"))
            {
                var ex = new Exception(reqFilePath + Environment.NewLine + errorText);
                throw ex;
            }

            var md5String = this.MD5File(reqFilePath);
            var dst_reqFilePath = this.caDataDir.TrimEnd('\\') + @"\reqwait\req" + md5String + ".pem";
            var dst_keyFilePath = this.caDataDir.TrimEnd('\\') + @"\reqprivate\key" + md5String + ".pem";
            File.Copy(reqFilePath, dst_reqFilePath, true);
            File.Copy(keyFilePath, dst_keyFilePath, true);
        }

        /// <summary>
        /// 生成用于req指令的subj文本
        /// </summary>
        /// <param name="subjectObj">主体对象</param>
        /// <returns>subj文本</returns>
        public string GetSubjectText(Subject subjectObj)
        {
            string subjectText = "";

            if (!String.IsNullOrWhiteSpace(subjectObj.CountryName))
            {
                subjectText += "/C=" + subjectObj.CountryName.Trim();
            }

            if (!String.IsNullOrWhiteSpace(subjectObj.StateOrProvinceName))
                subjectText += "/ST=" + subjectObj.StateOrProvinceName.Trim();

            if (!String.IsNullOrWhiteSpace(subjectObj.LocalityName))
                subjectText += "/L=" + subjectObj.LocalityName.Trim();

            if (!String.IsNullOrWhiteSpace(subjectObj.OrganizationName))
                subjectText += "/O=" + subjectObj.OrganizationName.Trim();

            if (!String.IsNullOrWhiteSpace(subjectObj.OrganizationalUnitName))
                subjectText += "/OU=" + subjectObj.OrganizationalUnitName.Trim();

            if (!String.IsNullOrWhiteSpace(subjectObj.CommonName))
                subjectText += "/CN=" + subjectObj.CommonName.Trim();

            if (!String.IsNullOrWhiteSpace(subjectObj.EmailAddress))
                subjectText += "/emailAddress=" + subjectObj.EmailAddress.Trim();//注意小写开头！emailAddress

            return subjectText;
        }
    }
}
