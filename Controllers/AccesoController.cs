

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace tallermvc.Controllers
{
    [Authorize(AuthenticationSchemes ="cookie1")]
    public class AccesoController : Controller
    {
        [Authorize(AuthenticationSchemes ="cookie1")]
        public IActionResult Index()
        {
            ViewData["Message"] = "Ingreso Correctamente";
            return View();
        }
    }

}