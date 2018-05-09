using hobby.Core.Model;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;

namespace hobby.Data
{
    public class HobbyContext:DbContext
    {
        static HobbyContext()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<HobbyContext>());
        }
        public HobbyContext():base("name=hobbyContext")
        {

        }

        public DbSet<User> user { get; set; }
        public DbSet<Menu> menu { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            var all = Assembly.GetExecutingAssembly();
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

      
    }
}
