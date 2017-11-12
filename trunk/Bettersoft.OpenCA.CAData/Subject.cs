using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bettersoft.OpenCA.CAData
{
    /// <summary>
    /// 证书主体内容定义
    /// </summary>
    public class Subject
    {
        public string CountryName { set; get; }
        public string StateOrProvinceName { set; get; }
        public string LocalityName { set; get; }
        public string OrganizationName { set; get; }
        public string OrganizationalUnitName { set; get; }
        public string CommonName { set; get; }
        public string EmailAddress { set; get; }
    }
}
