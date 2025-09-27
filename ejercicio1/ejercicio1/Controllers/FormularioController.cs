using Microsoft.AspNetCore.Mvc;

namespace ejercicio1.Controllers
{
    public class FormularioController : Controller
    {
            [HttpGet]
            public IActionResult Datos() => View();

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Datos(string nombre, DateTime fechaNacimiento)
            {
                int edad = DateTime.Now.Year - fechaNacimiento.Year;
                if (DateTime.Now.DayOfYear < fechaNacimiento.DayOfYear) edad--;
                ViewBag.Mensaje = $"Hola, {nombre}. Tienes {edad} años y tu año de nacimiento es {fechaNacimiento.Year}.";
                return View();

            }
    }
}
