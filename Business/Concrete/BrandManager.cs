using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void Add(Brand brand)
        {
            if(brand.Name.Length > 2)
            {
                _brandDal.Add(brand);
            }
            Console.WriteLine("Brand Name lenght should be higher than two characters!");
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(Brand brand)
        {
            return _brandDal.GetById(brand);
        }
        public Brand GetById(int id)
        {
            return _brandDal.GetById(id);
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }
    }
}
