using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        IRentalService _rentalService; //Default private

        public RentalController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }
        //

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _rentalService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }


        [HttpPost("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _rentalService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("Add")]
        public IActionResult Add(Rental rental)
        {
            var result = _rentalService.Add(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(Rental rental)
        {
            var result = _rentalService.Update(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Rental rental)
        {
            var result = _rentalService.Delete(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("RentalDetail")]
        public IActionResult RentalDetail()
        {
            var result = _rentalService.RentalDetail();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("RentACar")]
        public IActionResult RentACar()
        {
            var result = _rentalService.RentACar();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
