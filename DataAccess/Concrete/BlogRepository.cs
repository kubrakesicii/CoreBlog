using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.GenericRepository;
using Entities.Concrete;
using Entities.DTO.Blog;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class BlogRepository : GenericRepository<Blog>, IBlogRepository
    {
        public BlogRepository(BlogContext context) : base(context)
        {
        }

        public List<GetBlogDto> GetAllBlogs()
        {
            return _context.Blogs.Include(x => x.Category).Where(x => x.IsActive == 1).Select(x => new GetBlogDto
            {
                Id = x.Id,
                Title = x.Title,
                Content = x.Content,
                UserId = x.UserId,
                ImagePath = x.ImagePath,
                ThumbnailPath = x.ThumbnailPath,
                ViewCount = x.ViewCount,
                CategoryName = x.Category.Name
            }).ToList();
        }

        public GetBlogDto GetBlogById(int id)
        {
            return _context.Blogs.Include(x => x.Category).Where(x => x.Id == id).Select(x => new GetBlogDto
            {
                Id = x.Id,
                Title = x.Title,
                Content = x.Content,
                UserId=x.UserId,    
                ImagePath = x.ImagePath,
                ThumbnailPath = x.ThumbnailPath,
                ViewCount = x.ViewCount,
                CategoryName = x.Category.Name
            }).FirstOrDefault();
        }

        public List<GetBlogDto> GetBlogByWriter(int userId)
        {
            return _context.Blogs.Include(x => x.Category).Where(x => x.IsActive == 1 && x.UserId == userId).Select(x => new GetBlogDto
            {
                Id = x.Id,
                Title = x.Title,
                Content = x.Content,
                UserId = x.UserId,
                ImagePath = x.ImagePath,
                ThumbnailPath = x.ThumbnailPath,
                ViewCount = x.ViewCount,
                CategoryName = x.Category.Name
            }).ToList();
        }
    }
}
