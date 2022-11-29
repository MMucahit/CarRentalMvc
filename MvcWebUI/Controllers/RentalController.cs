using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class RentalController : Controller
    {
        RentalManager _rentals = new RentalManager(new EfRentalDal());

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            List<Rental> result = _rentals.GetAll().Data;
            return View("GetAll", result);
        }
        public IActionResult GetById(int id)
        {
            Rental result = _rentals.GetById(id).Data;
            return View("GetById", result);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Rental result = _rentals.GetById(id).Data;
            return View("Update", result);
        }

        [HttpPost]
        public IActionResult Update(Rental rental)
        {
            _rentals.Update(rental);
            Console.WriteLine("Updated");
            return RedirectToAction("GetAll");
        }

        [HttpPost]
        public IActionResult Delete(Rental rental)
        {
            _rentals.Delete(rental);
            Console.WriteLine("Deleted");
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult RentACar()
        {
            List<Rental> result = _rentals.RentACar().Data;
            return View("RentACar", result);
        }

        [HttpPost]
        public IActionResult RentACar(int id)
        {
            Rental result = _rentals.GetById(id).Data;
            result.RentDate = new DateTime(); //new DateTime() == null
            _rentals.Update(result);
            return RedirectToAction("RentACar");
        }
        public IActionResult RentalDetail()
        {
            List<RentalDetailDto> result = _rentals.RentalDetail().Data;
            return View("RentalDetail",result);
        }
    }
}
