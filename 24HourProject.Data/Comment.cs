using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourProject.Data
{
     public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CommentText { get; set; }

        [Required]
        public Guid Author { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }


        /// rough in for Replies

        //public virtual List<Reply> Reply { get; set; }

        //[ForeignKey(nameof(Reply))]

        //public int ReplyId { get; set; }

    }
}
