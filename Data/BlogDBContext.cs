using Microsoft.EntityFrameworkCore;
using Web.Blog.Models.Domain;

namespace Web.Blog.Data
{
    public class BlogDBContext : DbContext
    {
        public BlogDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPost { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
