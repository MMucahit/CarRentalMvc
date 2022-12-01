using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, Context>, IUserDal
    {
        public List<UserDetailDto> UserDetail()
        {
            using (Context _context = new Context())
            {
                var result = from user in _context.Users
                             join customer in _context.Customers
                             on user.Id equals customer.UserId
                             select new UserDetailDto
                             {
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 CompanyName = customer.CompanyName
                             };
                return result.ToList();
            }
        }
    }
}
