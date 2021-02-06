using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourProject.Data
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public virtual List<Comment> Comment { get; set; }

        [Required]
        public Guid AuthorId { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }
    }
}
