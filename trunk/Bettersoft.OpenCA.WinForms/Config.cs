using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bettersoft.OpenCA.WinForms
{
    public class Config
    {
        //public static string OPENSSL_DIR = @"D:\OpenSSL-Win32\bin";
        public static string OPENSSL_DIR = AppDomain.CurrentDomain.BaseDirectory.Trim('\\') + @"\OpenSSL";

        /// <summary>
        /// OpenSSL.exe文件路径
        /// </summary>
        public static string OPENSSL_FILE = OPENSSL_DIR + @"\OpenSSL.exe";

        /// <summary>
        /// CAData目录路径
        /// </summary>
        public static string CADATA_DIR = AppDomain.CurrentDomain.BaseDirectory.Trim('\\') + @"\CAData";
    }
}
