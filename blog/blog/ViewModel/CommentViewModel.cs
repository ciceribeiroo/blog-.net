using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.ViewModel
{
    public class CommentViewModel
    {
        [Required]
        public int Postid { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public int MainCommentId { get; set; }
    }
}
