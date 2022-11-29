using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
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
            List<Car> result = _cars.GetAll().Data;
            return View("GetAll", result);
        }

        public IActionResult GetById(int id)
        {
            Car result = _cars.GetById(id).Data;
            return View("GetById", result);
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
            Car result = _cars.GetById(id).Data;
            return View("Update", result);
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
            List<Car> result = _cars.GetCarsByBrandId(id).Data;
            return View("GetCarsByBrandId", result);
        }

        public IActionResult GetCarsByColorId(int id)
        {
            List<Car> result = _cars.GetCarsByColorId(id).Data;
            return View("GetCarsByColorId", result);
        }

        public IActionResult GetCarDetail()
        {
            List<CarDetailDto> result = _cars.GetCarDetail().Data.ToList();
            return View("GetCarDetail", result);
        }
    }
}