using CarRegistration.BusinessLogicLayer.Services.Interfaces;
using CarRegistration.WebApplication.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRegistration.WebApplication.Presentation.Controllers
{
    public class CarController : Controller
    {
        private ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpPost]
        public IActionResult Add([FromBody] AddCarViewModel addCarViewModel)
        {
            _carService.Add(addCarViewModel.OwnerId, addCarViewModel.EngineTypeId, addCarViewModel.CarModelId);
            return Ok();
        }
    }
}
