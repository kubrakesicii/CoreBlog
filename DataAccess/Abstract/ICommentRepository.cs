using DataAccess.GenericRepository;
using Entities.Concrete;
using Entities.DTO.Comment;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {
        void InsertComment(InsertCommentDto comment);
        List<GetCommentDto> GetCommentsByBlog(int blogId);
    }
}
