using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AuthorCoreWebsiteTemplate.Models;

namespace AuthorCoreWebsiteTemplate.Data
{
    public class AuthorCoreWebDbContext : IdentityDbContext
    {
        public AuthorCoreWebDbContext(DbContextOptions<AuthorCoreWebDbContext> options)
            : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
