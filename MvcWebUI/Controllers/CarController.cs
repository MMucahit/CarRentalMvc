using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class CarController : Controller
    {
        //InMemoryCarDal _cars = new InMemoryCarDal();
        //EfCarDal _cars = new EfCarDal();
        CarManager _cars = new CarManager(new EfCarDal());

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            List<Car> cars = _cars.GetAll();
            return View("GetAll", cars);
        }

        public IActionResult GetById(Car car)
        {
            Car _car = _cars.GetById(car);
            return View("GetById", _car);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public IActionResult Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("Added");
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Car _car = _cars.GetById(id);
            return View("Update", _car);
        }

        [HttpPost]
        public IActionResult Update(Car car)
        {
            _cars.Update(car);
            Console.WriteLine("Updated");
            return RedirectToAction("GetAll");
        }

        [HttpPost]
        public IActionResult Delete(Car car)
        {
            _cars.Delete(car);
            Console.WriteLine("Deleted");
            return RedirectToAction("GetAll");
        }

        public IActionResult GetCarsByBrandId(int id)
        {
            List<Car> cars = _cars.GetCarsByBrandId(id);
            return View("GetCarsByBrandId", cars);
        }

        public IActionResult GetCarsByColorId(int id)
        {
            List<Car> cars = _cars.GetCarsByColorId(id);
            return View("GetCarsByColorId", cars);
        }
    }
}