using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bettersoft.OpenCA.CAData
{
    /// <summary>
    /// 文本数据库index.txt中每一行证书数据记录
    /// </summary>
    public class CertRecord
    {
        public string State { get; set; }
        public string ExpiredTime { get; set; }
        public string StartTime { get; set; }
        public string SerialNo { get; set; }
        public string StoreDir { get; set; }
        public string DomainName { get; set; }
    }
}
