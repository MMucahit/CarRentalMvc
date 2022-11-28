using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        Car GetById(Car brand);
        Car GetById(int id);
        List<Car> GetAll();
        void Add(Car brand);
        void Update(Car brand);
        void Delete(Car brand);
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id); 
    }
}
