using log4net;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hobby.Data.LogNet
{
    public class LogMappingNet 
    {
        public void WriteLog(Type t, Exception e)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            log.Error("error",e);
        }
    }
}
