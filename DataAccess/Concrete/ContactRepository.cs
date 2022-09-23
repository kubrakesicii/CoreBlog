using DataAccess.Context;
using DataAccess.GenericRepository;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public class ContactRepository : GenericRepository<Contact>, IContactRepository
    {
        public ContactRepository(BlogContext context) : base(context)
        {
        }
    }
}
