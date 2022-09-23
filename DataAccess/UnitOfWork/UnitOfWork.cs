using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Context;
using DataAccess.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogContext _context;

        private readonly IUserRepository _userRepository;
        private readonly IBlogRepository _blogRepository;
        private readonly ICommentRepository _commentRepository;
        private readonly IContactRepository _contactRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IAboutRepository _aboutRepository;
        private readonly INewsletterRepository _newsletterRepository;

        public UnitOfWork(BlogContext context)
        {
            if (context == null)
                throw new ArgumentNullException("dbContext can not be null.");
            _context = context;
        }

        public IUserRepository Users => _userRepository ?? new UserRepository(_context);

        public IBlogRepository Blogs => _blogRepository ?? new BlogRepository(_context);

        public ICategoryRepository Categories => _categoryRepository ?? new CategoryRepository(_context);

        public ICommentRepository Comments => _commentRepository ?? new CommentRepository(_context);

        public IContactRepository Contacts => _contactRepository ?? new ContactRepository(_context);

        public IAboutRepository Abouts => _aboutRepository ?? new AboutRepository(_context);

        public INewsletterRepository Newsletters => _newsletterRepository ?? new NewsLetterRepository(_context);

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
