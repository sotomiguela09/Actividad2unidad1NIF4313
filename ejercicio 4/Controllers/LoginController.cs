using Microsoft.AspNetCore.Mvc;

namespace ejercicio_4.Controllers
{
    public class LoginController : Controller
    {
        
        

            [HttpGet]
            public IActionResult Index() => View();

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Index(string usuario, string clave)
            {
                if (usuario == "Miguela" && clave == "A0224")
                    return RedirectToAction("Bienvenido");
                ViewBag.Mensaje = "Usuario incorrecto";
                return View();
            }

        public IActionResult Bienvenido() => View();
           
        }
    }

