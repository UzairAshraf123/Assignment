namespace Task2.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Task2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Task2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Task2.Models.ApplicationDbContext context)
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
            var store = new UserStore<ApplicationUser>(context);
            var manager = new UserManager<ApplicationUser>(store);
            var adminUser = manager.FindByEmail("admin@admin.com");

            if (adminUser == null)
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManger = new RoleManager<IdentityRole>(roleStore);

                List<IdentityRole> identityRole = new List<IdentityRole>();
                identityRole.Add(new IdentityRole { Name = "User" });
                identityRole.Add(new IdentityRole { Name = "Employee" });
                identityRole.Add(new IdentityRole { Name = "Customer" });

                foreach (IdentityRole role in identityRole)
                {
                    roleManger.Create(role);
                }

                ApplicationUser user = new ApplicationUser();
                user.Email = "user@admin.com";
                user.UserName = "user@admin.com";

                manager.Create(user, "admin123");
                manager.AddToRole(user.Id, "User");
            }
        }
    }
}
