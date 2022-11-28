using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (Context _context = new Context())
            {
                _context.Add(entity);
                _context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (Context _context = new Context())
            {
                _context.Remove(entity);
                _context.SaveChanges();
            }
        }

        public List<Color> GetAll()
        {
            using (Context _context = new Context())
            {
                return _context.Set<Color>().ToList();
            }
        }

        public Color GetById(Color entity)
        {
            using (Context _context = new Context())
            {
                return _context.Set<Color>().SingleOrDefault(c => c.Id == entity.Id);
            }
        }

        public Color GetById(int id)
        {
            using (Context _context = new Context())
            {
                return _context.Set<Color>().SingleOrDefault(c => c.Id == id);
            }
        }

        public void Update(Color entity)
        {
            using (Context _context = new Context())
            {
                _context.Update(entity);
                _context.SaveChanges();
            }
        }
    }
}
