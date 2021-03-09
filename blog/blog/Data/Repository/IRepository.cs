using blog.Models;
using blog.Models.Comments;
using blog.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Data.Repository
{
    public interface IRepository
    {
        public Post GetPost(int id);
        public List<Post> GetAllPosts();
        public IndexViewModel GetAllPosts(int pageNumber, String Category, string search);
        public void AddPost(Post post);
        public void UpdatePost(Post post);
        public void RemovePost(int id);
        public void AddSubComment(SubComment comment);
        Task<bool> SaveChangesAsync();
    }
}
