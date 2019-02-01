using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AuthorCoreWebsiteTemplate.Models;

namespace AuthorCoreWebSiteTemplate.Data
{
    public class BloggingDbContext : IdentityDbContext
    {
        public BloggingDbContext(DbContextOptions<BloggingDbContext> options)
            : base(options)
        { }

        public DbSet<BlogModel> Blogs { get; set; }
        public DbSet<PostModel> Posts { get; set; }
    }
}