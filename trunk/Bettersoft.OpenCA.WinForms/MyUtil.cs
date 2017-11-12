using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Bettersoft.OpenCA.WinForms
{
    class MyUtil
    {
        static private string xmlFilePath = "OpenCA.NET.xml";

        /// <summary>
        /// 从OpenCA.NET.xml文件中获取登录口令
        /// </summary>
        /// <returns>登录口令</returns>
        static public string GetLoginPassword()
        {
            XDocument xdoc = XDocument.Load(MyUtil.xmlFilePath);
            var password_Base64 = xdoc.Element("Config").Element("LoginPassword").Value;
            var bytes = Convert.FromBase64String(password_Base64);
            var password = Encoding.UTF8.GetString(bytes);
            //MessageBox.Show(password);
            return password;
        }

        /// <summary>
        /// 保存登录口令到OpenCA.NET.xml文件中
        /// </summary>
        /// <param name="password">登录口令</param>
        /// <returns></returns>
        static public void SetLoginPassword(string password)
        {
            var bytes = Encoding.UTF8.GetBytes(password);
            var password_Base64 = Convert.ToBase64String(bytes);

            XDocument xdoc = XDocument.Load(MyUtil.xmlFilePath);
            xdoc.Element("Config").Element("LoginPassword").Value = password_Base64;
            xdoc.Save(xmlFilePath);
        }
    }
}
