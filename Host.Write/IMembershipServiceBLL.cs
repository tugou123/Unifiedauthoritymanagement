﻿using EnumInfo;
using Manager.Model.InputeMode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.IBLL
{
  public  interface IMembershipServiceBLL
    {
        LoginResultEnum Login(string username, string password, out LoginUser lou);


     
    }
}
