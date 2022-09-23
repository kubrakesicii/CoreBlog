using Business.Abstract;
using DataAccess.UnitOfWork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class NewsletterService : INewsletterService
    {
        private readonly IUnitOfWork _uow;

        public NewsletterService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void Insert(Newsletter n)
        {
            _uow.Newsletters.Insert(n);
            _uow.SaveChanges();
        }
    }
}
