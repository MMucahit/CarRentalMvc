using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            Console.WriteLine("Car Price should be higher than zero!");
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }

        public List<CarDetailDto> GetCarDetail()
        {
            return _carDal.GetCarDetail();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetCarsByBrandId(id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetCarsByColorId(id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
