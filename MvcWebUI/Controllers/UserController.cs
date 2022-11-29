using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class UserController : Controller
    {
        UserManager _users = new UserManager(new EfUserDal());

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAll()
        {
            List<User> result = _users.GetAll().Data;
            return View("GetAll",result);
        }
        public IActionResult GetById(int id) 
        {
            User result = _users.GetById(id).Data;
            return View("GetById",result);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            _users.Add(user);
            Console.WriteLine("Added");
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            User result = _users.GetById(id).Data;
            return View("Update", result);
        }

        [HttpPost]
        public IActionResult Update(User user)
        {
            _users.Update(user);
            Console.WriteLine("Updated");
            return RedirectToAction("GetAll");
        }

        [HttpPost]
        public IActionResult Delete(User user)
        {
            _users.Delete(user);
            Console.WriteLine("Deleted");
            return RedirectToAction("GetAll");
        }
    }
}
