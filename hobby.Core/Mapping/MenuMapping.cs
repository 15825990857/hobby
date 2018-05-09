using hobby.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hobby.Core.Mapping
{
  public  class MenuMapping:EntityTypeConfiguration<Menu>
    {
        public MenuMapping()
        {
            this.HasKey(p=>p.ID);
        }
    }
}
