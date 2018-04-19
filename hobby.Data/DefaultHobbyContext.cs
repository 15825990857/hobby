using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace hobby.Data
{
   public class DefaultHobbyContext
    {
        private static object DBLock = new object();

        public static HobbyContext GetCurrentDbContext()
        {
            HobbyContext dbContext = CallContext.GetData("DbContext") as HobbyContext;

            if (dbContext == null)
            {
                dbContext = new HobbyContext();
                CallContext.SetData("DbContext", dbContext);
            }
            return dbContext;
        }

        public static int SaveChanges()
        {
            return DefaultHobbyContext.GetCurrentDbContext().SaveChanges();
        }
    }
}
