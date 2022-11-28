using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;
using System.Diagnostics;

namespace MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}