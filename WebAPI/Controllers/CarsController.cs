using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        //Loosley Coupled
        //Naming Convention 
        //Inversion of Control (IoC)
        ICarService _carService; //Default private

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        //

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }


        [HttpPost("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _carService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("Add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("GetCarsByBrandId")]
        public IActionResult GetCarsByBrandId(int id)
        {
            var result = _carService.GetCarsByBrandId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("GetCarsByColorId")]
        public IActionResult GetCarsByColorId(int id)
        {
            var result = _carService.GetCarsByColorId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("GetCarDetail")]
        public IActionResult GetCarDetail()
        {
            var result = _carService.GetCarDetail();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
