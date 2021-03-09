using blog.Data.FileManager;
using blog.Data.Repository;
using blog.Models;
using blog.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Controllers
{
    [Authorize(Roles ="admin")]
    public class PanelController: Controller
    {
        private IRepository _repo;
        private IFileManager _fileManager;

        public PanelController(
            IRepository repo,
            IFileManager fileManager
            )
        {
            _repo = repo;
            _fileManager = fileManager;
        }
        public IActionResult Index()
        {
            var posts = _repo.GetAllPosts();
            return View(posts);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return View(new PostViewModel());
            else
            {
                var post = _repo.GetPost((int)id);
                var result = View(new PostViewModel
                {
                    Title = post.Title,
                    id = post.id,
                    Body = post.Body,
                    CurrentImage = post.Image,
                    Description = post.Description,
                    Category = post.Category,
                    Tags = post.Tags
                });
                return result;
            }
        }
        [HttpPost]
        public async Task<ActionResult> Edit(PostViewModel vm)
        {
            var post = new Post
            {
                Title = vm.Title,
                Body = vm.Body,
                id = vm.id,
                Description = vm.Description,
                Category = vm.Category,
                Tags = vm.Tags
            };
            if (vm.Image == null)
                post.Image = vm.CurrentImage;
            else
            {
                post.Image = await _fileManager.SaveImage(vm.Image);
            }
            if (post.id > 0)
                _repo.UpdatePost(post);
            else
                _repo.AddPost(post);

            if (await _repo.SaveChangesAsync())
                return RedirectToAction("Index");
            else
                return View(post);
        }
        [HttpGet]
        public async Task<IActionResult> Remove(int id)
        {
            _repo.RemovePost(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
