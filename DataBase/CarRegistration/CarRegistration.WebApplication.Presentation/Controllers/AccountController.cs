using CarRegistration.WebApplication.Presentation.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CarRegistration.WebApplication.Presentation.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login([FromForm] AccountLoginViewModel accountLoginViewModel)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, accountLoginViewModel.Email),
                new Claim("Password", accountLoginViewModel.Password),
                new Claim(ClaimTypes.Role, "Administrator"),
            };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity));
            return RedirectToAction("Auth");
        }

        public IActionResult Auth()
        {
            var a = User.Claims;
            return View();
        }
    }
}
