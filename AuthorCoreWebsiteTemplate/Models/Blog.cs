using System.ComponentModel.DataAnnotations;

namespace AuthorCoreWebsiteTemplate.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
    }
}
