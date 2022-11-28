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
            List<Color> colors = _colors.GetAll();
            return View("GetAll", colors);
        }

        public IActionResult GetById(int id)
        {
            Color _color = _colors.GetById(id);
            return View("GetById", _color);
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
            Color _color = _colors.GetById(id);
            return View("Update", _color);
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
