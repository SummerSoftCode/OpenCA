
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
        private string openSSLFilePath;
        private string caDataDir;
        private string configFilePath;

        private CADataHelper()
        {
            //null
        }

        public CADataHelper(string openSSLFilePath, string caDataDir)
        {
            this.openSSLFilePath = openSSLFilePath;
            this.caDataDir = caDataDir;
            this.configFilePath = this.caDataDir.TrimEnd('\\') + @"\openssl.cfg";
        }

        /// <summary>
        /// 获取OpenSSL版本
        /// </summary>
        /// <returns>OpenSSL版本</returns>
        public string GetOpenSSLVersion()
        {
            var version = CmdHelper.Execute(this.openSSLFilePath, "version");
            version = version.TrimStart("OpenSSL".ToCharArray())
                             .TrimEnd(Environment.NewLine.ToCharArray())
                             .Trim();
            return version;
        }

        /// <summary>
        /// 对文件进行MD5运算
        /// </summary>
        /// <param name="filePath">文件完整路径</param>
        /// <returns>文件的MD5结果</returns>
        public string MD5File(string filePath)
        {
            filePath = filePath.Replace('\\', '/');
            var arguments = " md5 " + filePath;
            var errorText = "";
            var resultText = CmdHelper.Execute(this.openSSLFilePath, arguments, out errorText);
            if (errorText.Contains("error"))
            {
                var ex = new Exception(errorText);
                throw ex;
            }
            var md5Text = resultText.Substring(resultText.IndexOf('=') + 1).TrimEnd('\n').Trim().ToUpper();

            return md5Text;
        }
    }
}
