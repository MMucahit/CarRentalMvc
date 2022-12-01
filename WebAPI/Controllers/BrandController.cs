using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        IBrandService _brandService; //Default private

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        //

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _brandService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }


        [HttpPost("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _brandService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("Add")]
        public IActionResult Add(Brand brand)
        {
            var result = _brandService.Add(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(Brand brand)
        {
            var result = _brandService.Update(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Brand brand)
        {
            var result = _brandService.Delete(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
