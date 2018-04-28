using EnumInfo;
using Manager.Model.InputeMode;
using Orleans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Contact.IComponet
{
  public interface IUserComponet: IGrainWithIntegerKey
    {
       Task<LoginResultEnum> Login(string username, string password, Action<LoginUser> lou);
    }
}
