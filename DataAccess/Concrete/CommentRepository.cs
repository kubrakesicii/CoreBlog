using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.GenericRepository;
using Entities.Concrete;
using Entities.DTO.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(BlogContext context) : base(context)
        {
        }

        public List<GetCommentDto> GetCommentsByBlog(int blogId)
        {
            return _context.Comments.Where(x => x.BlogId == blogId).Select(x => new GetCommentDto
            {
                Id = x.Id,
                Title = x.Title,
                Username = x.Username,
                Content = x.Content,
                CreatedAt = x.CreatedAt
            }).ToList();
        }

        public void InsertComment(InsertCommentDto comment)
        {
            var c = new Comment
            {
               // BlogId = comment.BlogId,
                BlogId = 6,
                Title = comment.Title,
                Username = comment.Username,
                Content = comment.Content,
                CreatedAt = DateTime.Now,
                IsActive = 1
            };
            Insert(c);
        }
    }
}
