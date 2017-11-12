
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Bettersoft.Common;

namespace Bettersoft.OpenCA.CAData
{
    public partial class CADataHelper
    {
        /// <summary>
        /// 从文本数据库index.txt中读取证书记录
        /// </summary>
        /// <param name="caDataDir">CAData目录</param>
        /// <returns>证书记录列表</returns>
        public List<CertRecord> GetCertList()
        {
            var certs = new List<CertRecord>();

            var textDbFile = this.caDataDir.Trim('\\') + @"\index.txt";
            var lines = File.ReadAllLines(textDbFile);
            foreach (var line in lines)
            {
                if (String.IsNullOrEmpty(line)) continue;

                var values = line.Split('\t');//分隔符是tab键
                var certRecord = new CertRecord();
                certRecord.State = values[0].Trim();
                certRecord.ExpiredTime = values[1].Trim();
                certRecord.StartTime = values[2].Trim();
                certRecord.SerialNo = values[3].Trim();
                certRecord.StoreDir = values[4].Trim();
                certRecord.DomainName = values[5].Trim();

                certs.Add(certRecord);
            }

            return certs;
        }

        /// <summary>
        /// 根据证书请求文件，签发一个证书
        /// </summary>
        /// <param name="reqFilePath">证书请求文件</param>
        /// <param name="caDataDir">CAData目录</param>
        /// <param name="caPassword">CA私钥保护口令</param>
        /// <returns></returns>
        public string SignCert(string reqFilePath, string caPassword)
        {
            var requestObj = this.GetRequestObj(reqFilePath);

            reqFilePath = reqFilePath.Replace('\\', '/');
            var myCADataDir = this.caDataDir.Replace('\\', '/');
            var reqFileName = reqFilePath.Substring(reqFilePath.LastIndexOf('/') + 1);

            var certFileDir = myCADataDir.TrimEnd('/') + "/certs";
            // -notext 不输出明文信息到证书文件中
            var arguments = " ca -batch -config " + this.configFilePath.Replace('\\','/') 
                             + " -in " + reqFilePath + " -passin pass:" + caPassword 
                             + " -outdir " + certFileDir 
                             + " -notext ";
            if (requestObj.SubjectType == SubjectType.User)
                arguments += " -extensions usr_cert";
            else
                arguments += " -extensions v3_ca";
            var errorText = "";
            var resultText = CmdHelper.Execute(this.openSSLFilePath, arguments, out errorText);
            if (errorText.Contains("error"))
            {
                var ex = new Exception(errorText);
                throw ex;
            }

            var lastCert = this.GetCertList().Last();

            //签发证书后，将证书申请文件从reqwait目录移到reqsigned
            var signed_reqFileName = reqFileName.Insert(reqFileName.IndexOf('.'), "-cert" + lastCert.SerialNo);
            var destFilePath = myCADataDir.TrimEnd('/') + "/reqsigned/" + signed_reqFileName;
            //destFilePath = FileHelper.GetUniqueFilePath(destFilePath);
            if (File.Exists(destFilePath))
                File.Delete(destFilePath);
            File.Move(reqFilePath, destFilePath);

            return resultText;
        }

        /// <summary>
        /// 吊销证书
        /// </summary>
        /// <param name="certFilePath">证书文件完整路径</param>
        /// <param name="caPassword">CA私钥保护口令</param>
        public void RevokeCert(string certFilePath, string caPassword)
        {
            certFilePath = certFilePath.Replace('\\', '/');
            var myCADataDir = this.caDataDir.Replace('\\', '/');

            var arguments = " ca -revoke " + certFilePath 
                            + " -config " + this.configFilePath.Replace('\\','/') 
                            + " -passin pass:" + caPassword;
            var errorText = "";
            var resultText = CmdHelper.Execute(this.openSSLFilePath, arguments, out errorText);
            if (errorText.Contains("error"))
            {
                var ex = new Exception(errorText);
                throw ex;
            }
        }

        /// <summary>
        /// 获取证书文件中的信息
        /// </summary>
        /// <param name="certFilePath">证书文件完整路径</param>
        /// <returns>证书文件中的信息</returns>
        public string GetCertText(string certFilePath)
        {
            certFilePath = certFilePath.Replace('\\', '/');
            var errorText = "";
            var arguments = " x509 -in " + certFilePath + " -text -noout";
            var resultText = CmdHelper.Execute(this.openSSLFilePath, arguments, out errorText);
            if (errorText.Contains("error"))
            {
                var ex = new Exception(errorText);
                throw ex;
            }

            return resultText;
        }

        /// <summary>
        /// 生成CRL（证书撤销列表）文件
        /// </summary>
        /// <param name="crlFilePath">要生成的证书撤销列表文件完整路径</param>
        /// <param name="caPassword">CA私钥保护密码</param>
        public void GenCRL(string crlFilePath, string caPassword) 
        {
            crlFilePath = crlFilePath.Replace('\\', '/');
            var myCADataDir = this.caDataDir.Replace('\\', '/');

            var arguments = " ca -gencrl -crldays 7 -out " + crlFilePath 
                            + " -config " + this.configFilePath.Replace('\\','/') 
                            + " -passin pass:" + caPassword;
            var errorText = "";
            var resultText = CmdHelper.Execute(this.openSSLFilePath, arguments, out errorText);
            if (errorText.Contains("error"))
            {
                var ex = new Exception(errorText);
                throw ex;
            }
        }

        /// <summary>
        /// 获取证书吊销列表文件的内容
        /// </summary>
        /// <param name="crlFilePath">证书吊销列表文件完整路径</param>
        /// <returns>证书吊销列表文件的内容</returns>
        public string GetCRLText(string crlFilePath)
        {
            crlFilePath = crlFilePath.Replace('\\', '/');
            var arguments = " crl -in " + crlFilePath + " -text -noout ";
            var errorText = "";
            var resultText = CmdHelper.Execute(this.openSSLFilePath, arguments, out errorText);
            if (errorText.Contains("error"))
            {
                var ex = new Exception(errorText);
                throw ex;
            }

            return resultText;
        }

        /// <summary>
        /// 生成p12证书文件
        /// </summary>
        /// <param name="keyFilePath">私钥文件完整路径</param>
        /// <param name="certFilePath">证书文件完整路径</param>
        /// <param name="p12FilePath">要生成的p12文件完整路径</param>
        public void GenP12Cert(string keyFilePath, string certFilePath, string p12FilePath)
        {
            keyFilePath = keyFilePath.Replace('\\', '/');
            certFilePath = certFilePath.Replace('\\', '/');
            p12FilePath = p12FilePath.Replace('\\', '/');
            var password = "123456";

            var arguments = " pkcs12 -export " 
                            + " -inkey " + keyFilePath
                            + " -passin pass:" + password
                            + " -passout pass:" + password
                            + " -in " + certFilePath
                            + " -out " + p12FilePath;
            var errorText = "";
            var resultText = CmdHelper.Execute(this.openSSLFilePath, arguments, out errorText);
            if (errorText.Contains("error"))
            {
                var ex = new Exception(errorText);
                throw ex;
            }
        }

        /// <summary>
        /// 生成PEM格式的p7证书（链）
        /// </summary>
        /// <param name="destPemFilePath">要生成的目标p7文件完整路径</param>
        /// <param name="crlFilePath">证书撤销列表文件完整路径</param>
        /// <param name="certFilePaths">要封装的证书文件完整路径列表</param>
        public void GenP7Cert(string destPemFilePath, string crlFilePath, params string[] certFilePaths)
        {
            destPemFilePath = destPemFilePath.Replace('\\', '/');
            crlFilePath = crlFilePath.Replace('\\', '/');

            var arguments = " crl2pkcs7  ";
            arguments += " -out " + destPemFilePath;
            if (String.IsNullOrWhiteSpace(crlFilePath))
                arguments += " -nocrl";
            else
                arguments += " -in " + crlFilePath;

            foreach (var certFilePath in certFilePaths)
            {
                if (!String.IsNullOrWhiteSpace(certFilePath))
                    arguments += " -certfile " + certFilePath;
            }
            var errorText = "";
            var resultText = CmdHelper.Execute(this.openSSLFilePath, arguments, out errorText);
            if (errorText.Contains("error"))
            {
                var ex = new Exception(errorText);
                throw ex;
            }
        }
        //--end--
    }
}
