
namespace Forum.App.Data
{
    using Microsoft.EntityFrameworkCore;
    public class ForumDbContext : DbContext;
    {
        public ForumDbContext(DbContextOptions<ForumDbContext> options)
            :base(options) 
        {

        }
    }
}
