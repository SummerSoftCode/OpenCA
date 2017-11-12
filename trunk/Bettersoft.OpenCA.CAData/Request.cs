using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bettersoft.OpenCA.CAData
{
    public class Request
    {
        public Subject SubjectObj { get; set; }
        public string SubjectText { get; set; }
        public string PublicKeyAlgorithm { set; get; }
        public string KeyBitLength { set; get; }
        public string SignatureAlgorithm { set; get; }
        public string FilePath { get; set; }
        public SubjectType SubjectType { set; get; }

        public Request()
        {
            this.SubjectType = SubjectType.User;
        }

    }
}
