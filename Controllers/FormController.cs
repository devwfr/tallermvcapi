

using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace tallermvc.Controllers
{
    [Authorize(AuthenticationSchemes ="cookie1")]
    public class FormController : Controller
    {
        [Authorize(AuthenticationSchemes ="cookie1")]
        public IActionResult Index()
        {
            return View();
        }

        [BindProperty]
        [Required]
        [StringLength(60, ErrorMessage = "La longitud del nombre debe ser de 60 caracteres")]
        public string Nombre { get; set; }
        [BindProperty]
        [Required]
        [StringLength(20, ErrorMessage = "La longitud de la direccion debe ser maximo de 20 caracteres.")]
        public string Direccion { get; set; }
        [BindProperty]
        [Required]
        [Phone]
        public string Telefono { get; set; }
        [BindProperty]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Authorize(AuthenticationSchemes ="cookie1")]
        public IActionResult RegistrarForm()
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }

            return View("Form");
        }
    }

}