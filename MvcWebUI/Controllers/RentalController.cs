using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class RentalController : Controller
    {
        IRentalService _rentalService;

        public RentalController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            List<Rental> result = _rentalService.GetAll().Data;
            return View("GetAll", result);
        }
        public IActionResult GetById(int id)
        {
            Rental result = _rentalService.GetById(id).Data;
            return View("GetById", result);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Rental result = _rentalService.GetById(id).Data;
            return View("Update", result);
        }

        [HttpPost]
        public IActionResult Update(Rental rental)
        {
            _rentalService.Update(rental);
            Console.WriteLine("Updated");
            return RedirectToAction("GetAll");
        }

        [HttpPost]
        public IActionResult Delete(Rental rental)
        {
            _rentalService.Delete(rental);
            Console.WriteLine("Deleted");
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult RentACar()
        {
            List<Rental> result = _rentalService.RentACar().Data;
            return View("RentACar", result);
        }

        [HttpPost]
        public IActionResult RentACar(int id)
        {
            Rental result = _rentalService.GetById(id).Data;
            result.RentDate = new DateTime(); //new DateTime() == null
            _rentalService.Update(result);
            return RedirectToAction("RentACar");
        }
        public IActionResult RentalDetail()
        {
            List<RentalDetailDto> result = _rentalService.RentalDetail().Data;
            return View("RentalDetail", result);
        }
    }
}
