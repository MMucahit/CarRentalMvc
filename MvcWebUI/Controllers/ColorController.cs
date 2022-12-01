using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class ColorController : Controller
    {
        IColorService _colorService;

        public ColorController(IColorService colorService)
        {
            _colorService = colorService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            List<Color> result = _colorService.GetAll().Data;
            return View("GetAll", result);
        }

        public IActionResult GetById(int id)
        {
            Color result = _colorService.GetById(id).Data;
            return View("GetById", result);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public IActionResult Add(Color color)
        {
            _colorService.Add(color);
            Console.WriteLine("Added");
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Color result = _colorService.GetById(id).Data;
            return View("Update", result);
        }

        [HttpPost]
        public IActionResult Update(Color color)
        {
            _colorService.Update(color);
            Console.WriteLine("Updated");
            return RedirectToAction("GetAll");
        }

        [HttpPost]
        public IActionResult Delete(Color color)
        {
            _colorService.Delete(color);
            Console.WriteLine("Deleted");
            return RedirectToAction("GetAll");
        }
    }
}
