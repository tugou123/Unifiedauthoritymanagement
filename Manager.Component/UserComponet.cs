using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumInfo;
using Manager.Contact.IComponet;
using Manager.Model.InputeMode;
using Orleans;
namespace Manager.Component
{
    public class UserComponet : ComponetBase, IUserComponet
    {
        public async Task<LoginResultEnum> Login(string username, string password, Action<LoginUser> lou)
        {
           await Task.Delay(1);
           
            if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(password))
                return LoginResultEnum.UserNameOrPasswordError;
            if(username!="123")
            return LoginResultEnum.UserNameUnExists;
            if (password != "123")
                return LoginResultEnum.VerifyCodeError;

            
           var log = new LoginUser()
            {
                Id = 1,
                Brower = "1",
                IsSaler = true,
                UserType = "系统管理员",
                Password = "123",
                RemenberMe = true,
                UId = 1,
                UserName = "123"
            };
            //异步机制不支持out/ref 参数传递 --解决方案:用Action/Func 委托 逆向传值
            lou.Invoke(log);
            return LoginResultEnum.Success;
        }
    }
}
