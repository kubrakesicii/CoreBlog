using Business.Abstract;
using DataAccess.UnitOfWork;
using Entities.Concrete;
using Entities.DTO.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogService : IBlogService
    {
        private readonly IUnitOfWork _uow;

        public BlogService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public List<GetBlogDto> GetAllBlogs()
        {
            return _uow.Blogs.GetAllBlogs();
        }

        public GetBlogDto GetBlogById(int id)
        {
            return _uow.Blogs.GetBlogById(id);
        }

        public List<GetBlogDto> GetBlogByWriter(int userId)
        {
            return _uow.Blogs.GetBlogByWriter(userId);
        }
    }
}
