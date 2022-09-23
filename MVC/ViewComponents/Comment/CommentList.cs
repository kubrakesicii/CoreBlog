using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MVC.ViewComponents.Comment
{
    public class CommentList : ViewComponent
    {
        private readonly ICommentService _commentService;

        public CommentList(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var commentsBylBlog = _commentService.GetCommentsByBlog(id);
            return View(commentsBylBlog);
        }
    }
}
