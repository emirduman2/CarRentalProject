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

        [HttpGet("get")] 
        public List<Car> Get()
        {
            var result = _carService.GetAll();
            return result.Data;
        }
    }
}