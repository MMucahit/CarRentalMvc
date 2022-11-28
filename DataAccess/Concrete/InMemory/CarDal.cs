using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class CarDal : ICarDal
    {
        List<Car> _cars = new List<Car>()
        {
            new Car { Id = 1,BrandId=1,ColorId=1, ModelYear=2019,DailyPrice=750_000,Description="..."},
            new Car { Id = 2,BrandId=1,ColorId=2, ModelYear=2004,DailyPrice=200_000,Description="..."},
            new Car { Id = 3,BrandId=2,ColorId=3, ModelYear=2022,DailyPrice=1_000_000,Description="..."},
            new Car { Id = 4,BrandId=2,ColorId=1, ModelYear=2000,DailyPrice=150_000,Description="..."},
            new Car { Id = 5,BrandId=3,ColorId=3, ModelYear=1995,DailyPrice=100_000,Description="..."}
        };

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(int id)
        {
            Car deletedCar = _cars.FirstOrDefault(c => c.Id == id);
            _cars.Remove(deletedCar);
        }
        public void Update(Car car)
        {
            Car existedCar = _cars.FirstOrDefault(c => c.Id == car.Id);
            car.BrandId = existedCar.BrandId;
            car.ColorId= existedCar.ColorId;
            car.ModelYear= existedCar.ModelYear;
            car.DailyPrice= existedCar.DailyPrice;
            car.Description= existedCar.Description;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.FirstOrDefault(c => c.Id == id);
        }


    }
}
