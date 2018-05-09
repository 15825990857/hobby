using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hobby.Core.Model
{
   public class Menu
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int  ParentID { get; set; }
        public int Sort { get; set; }
        public string  Action { get; set; }
        public string Controller { get; set; }
    }
}
