namespace NhanSu.Migrations
{
    using DataAccessLayer;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NhanSu.DataAccessLayer.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NhanSu.DataAccessLayer.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Phong.AddOrUpdate(t => t.Map,
                new Phong { Map = "MP01", TenP = "phong 1" },
                new Phong { Map = "MP02", TenP = "phong 2" },
                new Phong { Map = "MP03", TenP = "phong 3" },
                new Phong { Map = "MP04", TenP = "phong 4" },
                new Phong { Map = "MP05", TenP = "phong 5" }
                );
            context.User.AddOrUpdate(p => p.id,
                new User { id = 1, email = "admin@gmail.com", password = "123" }
                );
        }
    }
}
