
namespace Forum.App.Data
{
    using Microsoft.EntityFrameworkCore;
    using Forum.App.Data.Configuration;
    using Forum.App.Data.Models;
    public class ForumDbContext : DbContext
    {
        public ForumDbContext(DbContextOptions<ForumDbContext> options)
            :base(options) 
        {

        }

        public DbSet<Post> Posts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostEntityConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
