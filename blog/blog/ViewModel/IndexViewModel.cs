using blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.ViewModel
{
    public class IndexViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
        public bool NextPage { get; set; }
        public int PageCount { get; set; }
        public string Category { get; set; }
        public string Search { get; set; }
        public int PageNumber { get; set; }
        public IEnumerable<int> Pages { get; set; }
    }
}
