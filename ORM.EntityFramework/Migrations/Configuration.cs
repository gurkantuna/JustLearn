namespace ORM.EntityFramework.Migrations {
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ORM.EntityFramework.SportsContext> {
        public Configuration() {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ORM.EntityFramework.SportsContext context) {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Teams.AddOrUpdate(
                new Team { Id = 1, Name = "Beşiktas", City = "İstanbul" },
                new Team { Id = 2, Name = "Barcelona", City = "Barcelona" },
                new Team { Id = 3, Name = "Bayern Munich", City = "Munich" }
                );//you write to package manager console update-database
        }
    }
}