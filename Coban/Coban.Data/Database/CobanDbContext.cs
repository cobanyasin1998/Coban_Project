using Coban.Entities.Entity;
using Microsoft.EntityFrameworkCore;

namespace Coban.Data.Database
{
    public class CobanDbContext : DbContext
    {
        public CobanDbContext(DbContextOptions<CobanDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(builder);
        }
    }
}
