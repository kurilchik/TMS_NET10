using CarRegistration.BusinessLogicLayer.Services;
using CarRegistration.WebApplication.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRegistration.WebApplication.Presentation.Controllers
{
    public class DeveloperController : Controller
    {
        private DeveloperService _developerService;

        public DeveloperController()
        {
            _developerService = new DeveloperService();
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
