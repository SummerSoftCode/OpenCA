using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bettersoft.OpenCA.CAData
{
    /// <summary>
    /// 证书类型（根CA证书、下级CA证书、用户证书）
    /// </summary>
    public enum SubjectType
    {
        RootCA,
        SubCA,
        User
    }
}
