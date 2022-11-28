using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        Brand GetById(int id);
        List<Brand> GetAll();
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(Brand brand);
    }
}
