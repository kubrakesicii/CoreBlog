using DataAccess.Abstract;
using DataAccess.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IBlogRepository Blogs { get; }
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        IContactRepository Contacts { get; }
        IAboutRepository Abouts { get; }
        INewsletterRepository Newsletters { get; }
        int SaveChanges();
    }
}
