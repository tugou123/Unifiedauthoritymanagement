﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orleans;
namespace Manager.Component
{
    public class ComponetBase:Grain
    {
      public   IServiceProvider IocserviceProvider { set; get; }

    }
}
