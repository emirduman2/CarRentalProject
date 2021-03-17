using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : Controller
    {
        private IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpPost("Add")]
        public IActionResult Add(Rental rental)
        {
            var result = _rentalService.Add(rental);
            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut("Update")]
        public IActionResult Update(Rental rental)
        {
            var result = _rentalService.Update(rental);
            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Rental rental)
        {
            var result = _rentalService.Delete(rental);
            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int rentalId)
        {
            var result = _rentalService.GetRentalInfoByRentalId(rentalId);
            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        
        [HttpGet("GetRentalInfoByRentalCarId")]
        
        public IActionResult GetByRentalId(int rentalCarId)
        {
            var result = _rentalService.GetRentalInfoByRentalId(rentalCarId);
            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        
        [HttpGet("GetByCustomerId")]
        public IActionResult GetByCustomerId(int getRentalInfoByCustomerId)
        {
            var result = _rentalService.GetRentalInfoByRentalId(getRentalInfoByCustomerId);
            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _rentalService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}