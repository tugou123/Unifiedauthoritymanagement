using Manager.Model.InputeMode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orleans;
namespace Manager.Contact.IComponet
{
   public interface ISysLogComponet:IGrainWithIntegerKey
    {
        Task Add(Log log);

        Task Update(Log log);
    }
}
