using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{

    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var user = new UserViewModel() { Name = "Andrew", Age = 31 };
            return View(user);
        }

        public IActionResult New(string name, string age)
        {
            var user = new UserViewModel() { Name = name, Age = int.Parse(age) };
            return View(user);
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
