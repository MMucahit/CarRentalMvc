using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class ColorController : Controller
    {
        ColorManager _colors = new ColorManager(new EfColorDal());

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            List<Color> result = _colors.GetAll().Data;
            return View("GetAll", result);
        }

        public IActionResult GetById(int id)
        {
            Color result = _colors.GetById(id).Data;
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
            _colors.Add(color);
            Console.WriteLine("Added");
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Color result = _colors.GetById(id).Data;
            return View("Update", result);
        }

        [HttpPost]
        public IActionResult Update(Color color)
        {
            _colors.Update(color);
            Console.WriteLine("Updated");
            return RedirectToAction("GetAll");
        }

        [HttpPost]
        public IActionResult Delete(Color color)
        {
            _colors.Delete(color);
            Console.WriteLine("Deleted");
            return RedirectToAction("GetAll");
        }
    }
}
