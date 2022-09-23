using Business.Abstract;
using DataAccess.UnitOfWork;
using Entities.DTO.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _uow;

        public CommentService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public List<GetCommentDto> GetCommentsByBlog(int blogId)
        {
            return _uow.Comments.GetCommentsByBlog(blogId);
        }

        public void InsertComment(InsertCommentDto comment)
        {
            _uow.Comments.InsertComment(comment);
            _uow.SaveChanges();
        }
    }
}
