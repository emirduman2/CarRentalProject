using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class CarsController : ControllerBase
    {
        ICarService _carService;
        
        

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")] 
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();

            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _carService.GetById(id);
            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("Delete")]
        public IActionResult DeleteCar(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        
        

        [HttpPost("Add")]
        public IActionResult Add(Car car) // Post olduğu için, ne istediğimizi buraya yazıyoruz.
        {
            var result = _carService.Add(car);
            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
    }
}