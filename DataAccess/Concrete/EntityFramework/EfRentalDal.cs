using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, Context>, IRentalDal
    {
        public List<Rental> RentACar()
        {
            using (Context _context = new Context())
            {
                var result = from rent in _context.Rentals
                             where new DateTime() != rent.RentDate
                             select rent;
                return result.ToList();
            }
        }

        public List<RentalDetailDto> RentalDetail()
        {
            using (Context _context = new Context())
            {
                var result = from rent in _context.Rentals
                             join car in _context.Cars
                             on rent.CarId equals car.Id
                             join customer in _context.Customers
                             on rent.CustomerId equals customer.Id
                             join user in _context.Users
                             on customer.UserId equals user.Id
                             join brand in _context.Brands
                             on car.BrandId equals brand.Id
                             select new RentalDetailDto
                             {
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 CompanyName = customer.CompanyName,
                                 Brand = brand.Name,
                                 ModelYear = car.ModelYear
                             };
                return result.ToList();
            }
        }
    }
}
