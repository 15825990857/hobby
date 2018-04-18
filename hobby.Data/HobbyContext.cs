using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hobby.Data
{
    public class HobbyContext:DbContext
    {
        public HobbyContext():base("name=hobbyContext")
        {

        }
    }
}
