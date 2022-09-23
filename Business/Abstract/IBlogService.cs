using Entities.Concrete;
using Entities.DTO.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlogService
    {
        List<GetBlogDto> GetAllBlogs();
        GetBlogDto GetBlogById(int id);
        List<GetBlogDto> GetBlogByWriter(int userId);
    }
}
