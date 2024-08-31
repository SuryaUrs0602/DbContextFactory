using Microsoft.EntityFrameworkCore;

namespace IDbContextImplementation.Models
{
    public class EntityDbContext : DbContext
    {
        public EntityDbContext(DbContextOptions<EntityDbContext> context) : base(context)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           
        }

        public DbSet<Entity> Entities { get; set; }

    }
}
