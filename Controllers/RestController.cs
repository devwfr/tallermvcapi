

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tallermvc.Models;

namespace tallermvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public IActionResult InsertarContacto(Contacto contacto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            Console.WriteLine("****************Rest Api Post");
            Console.WriteLine(contacto.Nombre);
            return Ok(contacto);
        }
        /*
        https://localhost:5001/api/rest


            {
            "nombre": "Wilson",
            "direccion": "Chia",
            "telefono": "3212722217",
            "email": "forero-wilson@javeriana.edu.co"
            }

            'Accept: text/xml'

           <Contacto
            xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
            xmlns:xsd="http://www.w3.org/2001/XMLSchema">
            <Nombre>Wilson</Nombre>
            <Direccion>Chia</Direccion>
            <Telefono>3212722217</Telefono>
            <Email>forero-wilson@javeriana.edu.co</Email>
            </Contacto>
        
         */

    }


}
