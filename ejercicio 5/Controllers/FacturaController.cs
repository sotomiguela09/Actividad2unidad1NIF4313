using Microsoft.AspNetCore.Mvc;

namespace ejercicio_5.Controllers
{
    public class FacturaController : Controller

    {


        [HttpGet]
        public IActionResult Calcular() => View();
        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Calcular(decimal monto, string opcion)

        {
            decimal subtotal = monto;
            decimal impuesto = 0, descuento = 0, total = 0;
            if (opcion == "ITBIS")

            {
                impuesto = subtotal * 0.18m;
                total = subtotal + impuesto;
            }
            else
            {
                descuento = subtotal * 0.15m;
                total = subtotal - descuento;
            }
            ViewBag.Subtotal = subtotal;
            ViewBag.Impuesto = impuesto;
            ViewBag.Descuento = descuento;
            ViewBag.Total = total;
            
                return View();

            }
        }

    }
