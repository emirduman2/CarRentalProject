using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class CustomersController : Controller
    {
        private ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        
        [HttpGet("getall")] 
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();

            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _customerService.GetById(id);
            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpPost("Delete")]
        public IActionResult DeleteCar(Customer customer)
        {
            var result = _customerService.Delete(customer);
            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest();
        }
        
        

        [HttpPost("Add")]
        public IActionResult Add(Customer customer) // Post olduğu için, ne istediğimizi buraya yazıyoruz.
        {
            var result = _customerService.Add(customer);
            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest();
        }
    }
}