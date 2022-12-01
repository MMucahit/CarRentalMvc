using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class BrandController : Controller
    {
        IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            List<Brand> result = _brandService.GetAll().Data;
            return View("GetAll", result);
        }

        public IActionResult GetById(int id)
        {
            Brand result = _brandService.GetById(id).Data;
            return View("GetById", result);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public IActionResult Add(Brand brand)
        {
            _brandService.Add(brand);
            Console.WriteLine("Added");
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Brand result = _brandService.GetById(id).Data;
            return View("Update", result);
        }

        [HttpPost]
        public IActionResult Update(Brand brand)
        {
            _brandService.Update(brand);
            Console.WriteLine("Updated");
            return RedirectToAction("GetAll");
        }

        [HttpPost]
        public IActionResult Delete(Brand brand)
        {
            _brandService.Delete(brand);
            Console.WriteLine("Deleted");
            return RedirectToAction("GetAll");
        }
    }
}
