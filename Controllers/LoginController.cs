

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using tallermvc.Models;

namespace tallermvc.Controllers
{

    public class LoginController : Controller
    {
        private readonly IConfiguration configuration;
        public LoginController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        [BindProperty]
        public string UsuarioF { get; set; }
        [BindProperty, DataType(DataType.Password)]
        public string PasswordF { get; set; }
        public string Message { get; set; }
        public async Task<IActionResult> Loguear()
        {
            var user = configuration.GetSection("UsuarioAcceso").Get<UsuarioAcceso>();

            if (!ModelState.IsValid)
            {
                ViewData["Message"] = "Error en credenciales";
                return View("Index");
            }

            if (UsuarioF == user.usuario && PasswordF == user.password)
            {

                var identity1 = new ClaimsIdentity("cookie1");
                identity1.AddClaim(new Claim("name", UsuarioF));
                await HttpContext.SignInAsync("cookie1", new ClaimsPrincipal(identity1));

                return RedirectToAction("Index", "Acceso");
            }
            ViewData["Message"] = "Error en credenciales";
            return View("Index");

        }



        public IActionResult Logout()
        {
            var login = HttpContext.SignOutAsync("cookie1");
            return RedirectToAction("Index");
        }

    }


}