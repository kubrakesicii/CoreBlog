using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO.Blog
{
    public class GetBlogDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public int UserId { get; set; }
        //Küçük kapak resmi
        public string ThumbnailPath { get; set; }
        public int ViewCount { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreatedAt { get; set; }
        public int IsActive { get; set; }
    }
}
