

using Microsoft.AspNetCore.Mvc;

namespace tallermvc.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/x00")]
        public IActionResult Error()
        {
            return View("Error");
        }
    }
}