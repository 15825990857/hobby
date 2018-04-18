using hobby.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hobby.Core.Mapping
{
   public class UserMapping: EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            this.HasKey(p=>p.Id);
            this.Property(p => p.Name).HasMaxLength(250).IsRequired();
            this.Property(p => p.Pwd).HasMaxLength(250).IsRequired();
        }
    }
}
