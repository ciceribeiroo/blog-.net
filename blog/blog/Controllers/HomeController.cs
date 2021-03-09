using blog.Data;
using blog.Data.FileManager;
using blog.Data.Repository;
using blog.Models;
using blog.Models.Comments;
using blog.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repo;
        private IFileManager _fileManager;

        public HomeController(IRepository repo, IFileManager fileManager)
        {
            _repo = repo;
            _fileManager = fileManager;
        }
        public IActionResult Index(int pageNumber, string category, string search)
        {
            if(pageNumber < 1)
            {
                return RedirectToAction("Index", new { pageNumber = 1, category });
            }
            var vm = _repo.GetAllPosts(pageNumber, category, search);
            return View(vm);
        }
        public IActionResult Post(int id)
        {
            var post = _repo.GetPost(id);
            return View(post);
        }
        [HttpGet("/Image/{image}")]
        public IActionResult Image(string image)
        {
            var mime = image.Substring(image.LastIndexOf('.') + 1);
            return new FileStreamResult(_fileManager.ImageStream(image), $"Image/{mime}");
        }
        [HttpPost]
        public async Task<IActionResult> Comment(CommentViewModel vm)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Post", new { id = vm.Postid });

            var post = _repo.GetPost(vm.Postid);
            if (vm.MainCommentId == 0)
            {
                post.MainComments ??= new List<MainComment>();

                post.MainComments.Add(new MainComment
                {
                    Message = vm.Message,
                    Created = DateTime.Now
                });

                _repo.UpdatePost(post);
            }
            else
            {
                var comment = new SubComment{
                    MainCommentId = vm.MainCommentId,
                    Message = vm.Message,
                    Created = DateTime.Now
                };
                _repo.AddSubComment(comment);
            }
            await _repo.SaveChangesAsync();
            return RedirectToAction("Post", new { id = vm.Postid });
        }
    }
}
