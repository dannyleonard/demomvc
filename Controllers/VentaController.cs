using Microsoft.AspNetCore.Mvc;
using demomvc.Models;
namespace demomvc.Controllers
{
    public class VentaController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Prectotal(Venta objventa)
        {
            decimal subtotal = 0;
            decimal total = 0;
            
            if(objventa.Cantidad == 0){
                ViewData["Message"] = "No ha ingresado ninguna cantidad";
            }else{
subtotal = objventa.Precio * objventa.Cantidad;
            total = subtotal * (decimal)1.18;

            ViewData["Message"] = "El subtotal de la venta es "+ subtotal;
            ViewData["Message2"] = "El total de la venta es "+ total;
            }
            
            return View("Index");
        }
    }
}