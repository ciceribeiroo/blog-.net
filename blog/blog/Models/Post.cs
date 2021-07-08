using blog.Models.Comments;
using System;
using System.Collections.Generic;

namespace blog.Models
{
    public class Post
    {
        public int id { get; set; }
        public string Title { get; set; } = "";
        public string Body { get; set; } = "";
        public string Description { get; set; } = "";
        public string Tags { get; set; } = "";
        public string Category { get; set; } = "";
        public string Image { get; set; } = "";
        public string Legend { get; set; } = "";
        public DateTime Created { get; set; } = DateTime.Now;
        public List<MainComment> MainComments { get; set; }
    }
}
