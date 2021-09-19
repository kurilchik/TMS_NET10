using CarRegistration.BusinessLogicLayer.Services.Interfaces;
using CarRegistration.WebApplication.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CarRegistration.WebApplication.Presentation.Controllers
{
    public class DeveloperController : Controller
    {
        private IDeveloperService _developerService;

        public DeveloperController(IDeveloperService developerService)
        {
            _developerService = developerService;            
        }

        public IActionResult Index()
        {
            var developers = _developerService.GetList();

            DevelopersViewModel developersView = new DevelopersViewModel() { Developers = new List<DeveloperViewModel>() };

            foreach (var item in developers)
            {
                DeveloperViewModel developer = new DeveloperViewModel() { Age = item.Age, Name = item.Name };

                developersView.Developers.Add(developer);
            }

            return View(developersView);
        }

        [HttpPost]
        public IActionResult Add([FromForm]AddDeveloperDTO addDeveloperDTO)
        {
            _developerService.Add(addDeveloperDTO.Name, addDeveloperDTO.Age);

            return RedirectToAction("Index");
        }
    }
}
