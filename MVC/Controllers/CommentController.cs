using Business.Abstract;
using Entities.Concrete;
using Entities.DTO.Comment;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Web.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {

            return PartialView();
        }

        [HttpPost]
        public PartialViewResult AddComment(InsertCommentDto c)
        {
            c.BlogId = 2;
            _commentService.InsertComment(c);
            return PartialView();
        }

        public PartialViewResult GetCommentsByBlog(int blogId)
        {
            var comments = _commentService.GetCommentsByBlog(blogId);
            return PartialView(comments);
        }
    }
}
