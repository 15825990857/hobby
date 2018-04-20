using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hobby.Cenum
{
   public enum ResultStatus
    {
        [Description("成功")]
        Success=1,
        [Description("失败")]
        fail=0,
     
    }
}
