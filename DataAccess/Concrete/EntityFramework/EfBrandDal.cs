using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (Context _context = new Context())
            {
                _context.Add(entity);
                _context.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (Context _context = new Context())
            {
                _context.Remove(entity);
                _context.SaveChanges();
            }
        }

        public List<Brand> GetAll()
        {
            using (Context _context = new Context())
            {
                return _context.Set<Brand>().ToList();
            }
        }

        public Brand GetById(Brand entity)
        {
            using (Context _context = new Context())
            {
                return _context.Set<Brand>().SingleOrDefault(b => b.Id == entity.Id);
            }
        }

        public Brand GetById(int id)
        {
            using (Context _context = new Context())
            {
                return _context.Set<Brand>().SingleOrDefault(b => b.Id == id);
            }
        }

        public void Update(Brand entity)
        {
            using (Context _context = new Context())
            {
                _context.Update(entity);
                _context.SaveChanges();
            }
        }
    }
}
