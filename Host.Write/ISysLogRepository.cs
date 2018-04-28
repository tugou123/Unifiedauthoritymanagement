using Manager.Model.InputeMode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.IBLL
{
   public interface ISysLogRepository
    {
        void Add(Log log);

        void Update(Log log);
    }
}
