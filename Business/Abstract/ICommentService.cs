using Entities.DTO.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICommentService
    {
        void InsertComment(InsertCommentDto comment);
        List<GetCommentDto> GetCommentsByBlog(int blogId);
    }
}
