using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MVC.ViewComponents.Blog
{
    public class BlogsByUser : ViewComponent
    {
        private readonly IBlogService _blogService;

        public BlogsByUser(IBlogService blogServic)
        {
            _blogService = blogServic;
        }

        public IViewComponentResult Invoke(int userId)
        {
            var blogs = _blogService.GetBlogByWriter(userId);
            return View(blogs);
        }
    }
}
