using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            var blogs = _blogService.GetAllBlogs();
            return View(blogs);
        }

        public IActionResult Detail([FromRoute] int id)
        {
            var blog = _blogService.GetBlogById(id);
            ViewBag.id = id;
            ViewBag.userId = blog.UserId;

            return View(blog);
        }
    }
}
