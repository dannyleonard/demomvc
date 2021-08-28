using Microsoft.AspNetCore.Mvc;
using demomvc.Models;
namespace demomvc.Controllers
{
    public class CalculadoraController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(Calculadora objcalculadora)
        {
            decimal operacion = 0;
            ViewData["Message"] = "Sin resultado";
            if(objcalculadora.Operador.Equals("+")){

                operacion = objcalculadora.Operando1 + objcalculadora.Operando2;
                ViewData["Message"] = "El resultado de la operacion es "+ operacion;
            }else if(objcalculadora.Operador.Equals("/")){
                if(objcalculadora.Operando2 == 0){
                    ViewData["Message"] = "No se puede dividir entre 0";
                }else{
                    operacion = objcalculadora.Operando1 / objcalculadora.Operando2;
                    ViewData["Message"] = "El resultado de la division es "+ operacion;
                }
            }
            
            return View("Index");
        }
    }
}