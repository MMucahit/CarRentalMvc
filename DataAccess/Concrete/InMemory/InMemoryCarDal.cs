using DataAccess.Abstract;
using Entities.Concrete;

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
            _cars.Add(entity);
        }

        public void Delete(Car entity)
        {
            Car deletedCar = _cars.FirstOrDefault(c => c.Id == entity.Id);
            _cars.Remove(deletedCar);
        }
        public void Update(Car entity)
        {
            Car existedCar = _cars.FirstOrDefault(c => c.Id == entity.Id);
            entity.BrandId = existedCar.BrandId;
            entity.ColorId = existedCar.ColorId;
            entity.ModelYear = existedCar.ModelYear;
            entity.DailyPrice = existedCar.DailyPrice;
            entity.Description = existedCar.Description;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(Car entity)
        {
            return _cars.FirstOrDefault(c => c.Id == entity.Id);
        }
        public Car GetById(int id)
        {
            return _cars.FirstOrDefault(c => c.Id == id);
        }
    }
}
