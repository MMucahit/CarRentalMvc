using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class UserController : Controller
    {
        IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAll()
        {
            List<User> result = _userService.GetAll().Data;
            return View("GetAll", result);
        }
        public IActionResult GetById(int id)
        {
            User result = _userService.GetById(id).Data;
            return View("GetById", result);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            _userService.Add(user);
            Console.WriteLine("Added");
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            User result = _userService.GetById(id).Data;
            return View("Update", result);
        }

        [HttpPost]
        public IActionResult Update(User user)
        {
            _userService.Update(user);
            Console.WriteLine("Updated");
            return RedirectToAction("GetAll");
        }

        [HttpPost]
        public IActionResult Delete(User user)
        {
            _userService.Delete(user);
            Console.WriteLine("Deleted");
            return RedirectToAction("GetAll");
        }

        public IActionResult UserDetail()
        {
            List<UserDetailDto> result = _userService.UserDetail().Data;
            return View("UserDetail", result);
        }
    }
}
