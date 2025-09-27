using Microsoft.AspNetCore.Mvc;

namespace ejercicio3.Controllers
{
    public class NumeroController : Controller
    {
        [HttpGet]
        public IActionResult Fibonacci() => View();
        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Fibonacci(int numero)
        {
            bool pertenece = PerteneceAFibonacci(numero);
            ViewBag.Mensaje = pertenece ? $"{numero} pertenece a Fibonacci" : $"{numero} NO pertenece a Fibonacci";
            return View();
        }

        private bool PerteneceAFibonacci(int n)
        {
            int a = 0, b = 1;
            while (a < n) { int t = a; a = b; b = t + b; }
            return a == n;

        }
    }
}
