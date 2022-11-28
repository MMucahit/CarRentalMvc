using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (Context _context = new Context())
            {
                _context.Add(entity);
                _context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (Context _context = new Context())
            {
                _context.Remove(entity);
                _context.SaveChanges();
            }
        }

        public List<Car> GetAll()
        {
            using (Context _context = new Context())
            {
                return _context.Set<Car>().ToList();
            }
        }

        public Car GetById(Car entity)
        {
            using (Context _context = new Context())
            {
                return _context.Set<Car>().SingleOrDefault(c => c.Id == entity.Id);
            }
        }

        public Car GetById(int id)
        {
            using (Context _context = new Context())
            {
                return _context.Set<Car>().SingleOrDefault(c => c.Id == id);
            }
        }

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

        public void Update(Car entity)
        {
            using (Context _context = new Context())
            {
                _context.Update(entity);
                _context.SaveChanges();
            }
        }
    }
}
