using Angular4Mvc.Models;

namespace Angular4Mvc.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;

        }

        protected override void Seed(ApplicationDbContext context)
        {

            context.Users.AddOrUpdate(
              p => p.Id,
              new User { Id = 1, FirstName = "Andrew", LastName = "Peters", Gender = "Male" },
              new User { Id = 2, FirstName = "Brice", LastName = "Lambson", Gender = "Male" },
              new User { Id = 3, FirstName = "Rowan", LastName = "Miller", Gender = "Male" }
            );

        }
    }
}
