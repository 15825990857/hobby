namespace hobby.Data.Migrations
{
    using hobby.Common;
    using hobby.Core.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<hobby.Data.HobbyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(hobby.Data.HobbyContext context)
        {
            context.user.AddOrUpdate(p =>
              p.Name,
              new User {
                  Name = "admin",
                  Addtime = DateTime.Now.ToShortDateString(),
                  Pwd = Encrypt.EncryptMD5By32("000000"),
                  Status = 0
              }
            );
        }
    }
}
