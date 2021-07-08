using blog.Helpers;
using blog.Models;
using blog.Models.Comments;
using blog.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Data.Repository
{
    public class Repository : IRepository
    {
        private AppDbContext _ctx;

        public Repository(AppDbContext ctx)
        {
            _ctx = ctx;
        }
        public void AddPost(Post post)
        {
            _ctx.Posts.Add(post);
        }

        public List<Post> GetAllPosts()
        {
            return _ctx.Posts.OrderByDescending(post => post.Created).ToList();
        }

        public IndexViewModel GetAllPosts(int pageNumber, string Category, string search)
        {
            Func<Post, bool> InCategory = (post) => { return post.Category.ToLower().Equals(Category.ToLower()); };
            int pageSize = 4;
            int skipAmount = pageSize * (pageNumber - 1);
            var query = _ctx.Posts.OrderByDescending(post => post.Created).ToList();

            if (!String.IsNullOrEmpty(Category))
            {
                query = query.Where(x => x.Category.Equals(Category, StringComparison.InvariantCultureIgnoreCase)).ToList();
            }

            if (!String.IsNullOrEmpty(search))
            {
                
                query = query.Where(x => (x.Title.Contains(search, StringComparison.InvariantCultureIgnoreCase)||
                                   x.Body.Contains(search, StringComparison.InvariantCultureIgnoreCase)||
                                   x.Description.Contains(search, StringComparison.InvariantCultureIgnoreCase)))
                                   .ToList();
                /*
                 * query = query.Where(x => EF.Functions.Like(x.Title, $"%{search}%") ||
                                         EF.Functions.Like(x.Body, $"%{search}%") ||
                                         EF.Functions.Like(x.Description, $"%{search}%"))
                                         .ToList();
                */
            }

            int postCount = query.Count();
            int pageCount = (int)Math.Ceiling((double)postCount / pageSize);

            return new IndexViewModel
            {
                Posts = query
                        .Skip(skipAmount)
                        .Take(pageSize)
                        .ToList(),
                PageCount = pageCount,
                Pages = PageHelper.PageNumbers(pageNumber, pageCount).ToList(),
                NextPage = postCount > skipAmount + pageSize,
                PageNumber = pageNumber,
                Category = Category,
                Search = search
            };
        }

        public Post GetPost(int id)
        {
            return _ctx.Posts
                .Include( p => p.MainComments)
                    .ThenInclude( mc => mc.SubComments)
                .FirstOrDefault(p => p.id == id);
        }

        public void RemovePost(int id)
        {
            _ctx.Posts.Remove(GetPost(id));
        }
        public void UpdatePost(Post post)
        {
            _ctx.Update(post);
        }
        public async Task<bool> SaveChangesAsync()
        {
            if(await _ctx.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }

        public void AddSubComment(SubComment comment)
        {
            _ctx.SubComments.Add(comment);
        }
    }
}
