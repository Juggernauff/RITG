using System.ComponentModel.DataAnnotations;

namespace TaskMVC.Models
{
    public class News
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public bool Published { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
