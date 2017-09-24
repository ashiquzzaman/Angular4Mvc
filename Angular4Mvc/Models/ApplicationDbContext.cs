using System.Data.Entity;

namespace Angular4Mvc.Models
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext() : base("name=DefaultConnection")
        {
        }

        public DbSet<User> Users { get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}