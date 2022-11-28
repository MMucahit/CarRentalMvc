using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class BrandController : Controller
    {
        BrandManager _brands = new BrandManager(new EfBrandDal());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            List<Brand> brand = _brands.GetAll();
            return View("GetAll", brand);
        }

        public IActionResult GetById(int id)
        {
            Brand _brand = _brands.GetById(id);
            return View("GetById", _brand);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public IActionResult Add(Brand brand)
        {
            _brands.Add(brand);
            Console.WriteLine("Added");
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Brand _brand = _brands.GetById(id);
            return View("Update", _brand);
        }

        [HttpPost]
        public IActionResult Update(Brand brand)
        {
            _brands.Update(brand);
            Console.WriteLine("Updated");
            return RedirectToAction("GetAll");
        }

        [HttpPost]
        public IActionResult Delete(Brand brand)
        {
            _brands.Delete(brand);
            Console.WriteLine("Deleted");
            return RedirectToAction("GetAll");
        }
    }
}
