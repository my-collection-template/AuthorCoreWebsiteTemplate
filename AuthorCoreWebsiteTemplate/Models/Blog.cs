using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AuthorCoreWebsiteTemplate.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Url { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
