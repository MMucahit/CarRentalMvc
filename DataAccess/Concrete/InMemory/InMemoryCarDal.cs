using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
        {
            new Car { Id = 1,BrandId=1,ColorId=1, ModelYear=2019,DailyPrice=750_000,Description="..."},
            new Car { Id = 2,BrandId=1,ColorId=2, ModelYear=2004,DailyPrice=200_000,Description="..."},
            new Car { Id = 3,BrandId=2,ColorId=3, ModelYear=2022,DailyPrice=1_000_000,Description="..."},
            new Car { Id = 4,BrandId=2,ColorId=1, ModelYear=2000,DailyPrice=150_000,Description="..."},
            new Car { Id = 5,BrandId=3,ColorId=3, ModelYear=1995,DailyPrice=100_000,Description="..."}
        };
        }

        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
