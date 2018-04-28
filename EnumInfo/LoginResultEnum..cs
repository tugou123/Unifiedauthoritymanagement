using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumInfo
{
    public enum LoginResultEnum
    {
        Success = 10,
        UserNameUnExists = 20,
        VerifyCodeError = 30,
        UserNameOrPasswordError = 40
    }
    
}
