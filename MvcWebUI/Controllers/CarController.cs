using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;
using System.Diagnostics;

namespace MvcWebUI.Controllers
{
    public class CarController : Controller
    {
        CarDal _cars = new CarDal();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            List<Car> cars = _cars.GetAll();
            return View("GetAll",cars);
        }

        public IActionResult GetById(int id)
        {
            Car car = _cars.GetById(id);
            return View("GetById", car);
        }

        [HttpGet]
        public IActionResult Add() 
        {
            return View("Add");
        }

        [HttpPost]
        public IActionResult Add(Car car) 
        {
            _cars.Add(car);
            Console.WriteLine("Added");
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Car car = _cars.GetById(id);
            return View("Update", car);
        }

        [HttpPost]
        public IActionResult Update(Car car) 
        {
            _cars.Update(car);
            return RedirectToAction("GetAll");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _cars.Delete(id);
            return RedirectToAction("GetAll");
        }
    }
}