
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
        /// 生成自签名的CA证书和私钥
        /// </summary>
        public void GenCACert(string password)
        {
            var cakeyFile = this.caDataDir.Replace('\\', '/').TrimEnd('/') + "/private/cakey.pem";
            var cacertFile = this.caDataDir.Replace('\\', '/').TrimEnd('/') + "/cacert.pem";

            var arguments = " req -config " + this.configFilePath.Replace('\\','/')
                            + " -x509 -newkey rsa:2048 -keyout " + cakeyFile + " -passout pass:" + password 
                            + " -out " + cacertFile 
                            + " -subj /CN=RootCA";
            var errorText = "";
            var result = CmdHelper.Execute(this.openSSLFilePath, arguments, out errorText);
            if (errorText.Contains("error"))
            {
                var ex = new Exception(errorText);
                throw ex;
            }
        }
    }
}
