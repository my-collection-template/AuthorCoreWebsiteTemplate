using System.ComponentModel.DataAnnotations;

namespace AuthorCoreWebsiteTemplate.Models
{
    public class Sample
    {
        [Key]
        public int SampleId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
