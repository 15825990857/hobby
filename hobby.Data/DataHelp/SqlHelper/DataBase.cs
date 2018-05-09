using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hobby.Data.DataHelp.SqlHelper
{
   public class DataBase
    {
        public DbParameter CreateParmeter(DbCommand cmd, String pName, Object value, System.Data.DbType type)
        {
            var p = cmd.CreateParameter();
            p.ParameterName = pName;
            p.Value = (value==null?DBNull.Value:value);
            p.DbType = type;
            return p;
        }
    }
}
