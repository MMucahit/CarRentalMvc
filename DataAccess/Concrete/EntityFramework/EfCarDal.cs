using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, Context>, ICarDal
    {
        public List<Car> GetCarsByBrandId(int id)
        {
            using (Context _context = new Context())
            {
                return _context.Set<Car>().Where(c => c.BrandId == id).ToList();
            }
        }

        public List<Car> GetCarsByColorId(int id)
        {
            using (Context _context = new Context())
            {
                return _context.Set<Car>().Where(c => c.ColorId == id).ToList();
            }
        }

        public List<CarDetailDto> GetCarDetail()
        {
            using (Context _context = new Context())
            {
                var result = from car in _context.Cars
                             join color in _context.Colors
                             on car.ColorId equals color.Id
                             join brand in _context.Brands
                             on car.BrandId equals brand.Id
                             select new CarDetailDto
                             {
                                 BrandName = brand.Name,
                                 ColorName = color.Name,
                                 DailyPrice = car.DailyPrice,
                             };
                return result.ToList();
            }
        }

    }
}
