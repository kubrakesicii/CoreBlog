using Core.Errors;
using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.GenericRepository;
using DataAccess.Helper;
using Entities.Concrete;
using Entities.DTO.User;

namespace DataAccess.Concrete
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(BlogContext context) : base(context)
        {
        }

       
    }
}
