using Microsoft.AspNetCore.Mvc;

namespace ejerccio_2.Controllers
{
    public class OperacionController : Controller
   
      

        {
            [HttpGet]
            public IActionResult Calcular() => View();

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Calcular(double num1, double num2, string operacion)
            {
                double resultado = 0;
                switch (operacion)
                {
                    case "Sumar": resultado = num1 + num2; break;
                    case "Restar": resultado = num1 - num2; break;
                    case "Multiplicar": resultado = num1 * num2; break;
                    case "Dividir": resultado = (num2 != 0) ? num1 / num2 : double.NaN; break;
                    case "Potencia": resultado = Math.Pow(num1, num2); break;
                }
                ViewBag.Resultado = resultado;
                ViewBag.Operacion = operacion;
                return View();
        }
    }
}
