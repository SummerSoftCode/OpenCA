
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
        /// 证书格式转换PEM2DER
        /// </summary>
        /// <param name="pemCertFilePath">PEM格式证书文件完整路径</param>
        /// <param name="derCertFilePath">DER格式证书文件完整路径</param>
        public void PemX509CertToDerX509Cert(string pemCertFilePath, string derCertFilePath)
        {
            pemCertFilePath = pemCertFilePath.Replace('\\', '/');
            derCertFilePath = derCertFilePath.Replace('\\', '/');
            var arguments = " x509 -in " + pemCertFilePath + " -inform PEM -out " + derCertFilePath + " -outform DER";
            var errorText = "";
            var resultText = CmdHelper.Execute(this.openSSLFilePath, arguments, out errorText);
            if (errorText.Contains("error"))
            {
                var ex = new Exception(errorText);
                throw ex;
            }
        }

        /// <summary>
        /// 将PEM格式的CRL转换为DER格式的CRL
        /// </summary>
        /// <param name="pemCRLFilePath">PEM格式的CRL文件完整路径</param>
        /// <param name="derCRLFilePath">DER格式的CRL文件完整路径</param>
        public void PemCRLToDerCRL(string pemCRLFilePath, string derCRLFilePath)
        {
            pemCRLFilePath = pemCRLFilePath.Replace('\\', '/');
            derCRLFilePath = derCRLFilePath.Replace('\\', '/');

            var arguments = " crl -in " + pemCRLFilePath 
                            + " -out " + derCRLFilePath 
                            + " -outform DER";
            var errorText = "";
            var resultText = CmdHelper.Execute(this.openSSLFilePath, arguments, out errorText);
            if (errorText.Contains("error"))
            {
                var ex = new Exception(errorText);
                throw ex;
            }
        }

        /// <summary>
        /// 将PEM格式的p7证书转换为DER格式的p7证书
        /// </summary>
        /// <param name="pemP7FilePath">PEM格式的p7证书文件完整路径</param>
        /// <param name="derP7FilePath">DER格式的p7证书文件完整路径</param>
        public void PemP7CertToDerP7Cert(string pemP7FilePath, string derP7FilePath)
        {
            pemP7FilePath = pemP7FilePath.Replace('\\', '/');
            derP7FilePath = derP7FilePath.Replace('\\', '/');

            var arguments = " pkcs7 -in " + pemP7FilePath
                            + " -out " + derP7FilePath
                            + " -outform DER";
            var errorText = "";
            var resultText = CmdHelper.Execute(this.openSSLFilePath, arguments, out errorText);
            if (errorText.Contains("error"))
            {
                var ex = new Exception(errorText);
                throw ex;
            }
        }

    }
}
