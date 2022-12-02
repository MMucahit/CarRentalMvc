using Business.AbstractValidator;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class CarController : Controller
    {
        //InMemoryCarDal _cars = new InMemoryCarDal();
        //EfCarDal _cars = new EfCarDal();
        //CarManager _cars = new CarManager(new EfCarDal());

        ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            List<Car> result = _carService.GetAll().Data;
            return View("GetAll", result);
        }

        public IActionResult GetById(int id)
        {
            Car result = _carService.GetById(id).Data;
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
            _carService.Add(car);
            Console.WriteLine("Added");
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Car result = _carService.GetById(id).Data;
            return View("Update", result);
        }

        [HttpPost]
        public IActionResult Update(Car car)
        {
            _carService.Update(car);
            Console.WriteLine("Updated");
            return RedirectToAction("GetAll");
        }

        [HttpPost]
        public IActionResult Delete(Car car)
        {
            _carService.Delete(car);
            Console.WriteLine("Deleted");
            return RedirectToAction("GetAll");
        }

        public IActionResult GetCarsByBrandId(int id)
        {
            List<Car> result = _carService.GetCarsByBrandId(id).Data;
            return View("GetCarsByBrandId", result);
        }

        public IActionResult GetCarsByColorId(int id)
        {
            List<Car> result = _carService.GetCarsByColorId(id).Data;
            return View("GetCarsByColorId", result);
        }

        public IActionResult GetCarDetail()
        {
            List<CarDetailDto> result = _carService.GetCarDetail().Data.ToList();
            return View("GetCarDetail", result);
        }
    }
}