using Microsoft.AspNetCore.Mvc;
using AS2324_5G_INF_BunardziuVehap_webAPI.Models;

namespace AS2324_5G_INF_BunardziuVehap_webAPI.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("Multiplo")]
        public JsonResult Multiplo(int A, int B)
        {
            string messaggio = "OK";
            var operazioni = new Operazioni();
            operazioni.N1 = A;
            operazioni.N2 = B;
            if (operazioni.N_positivo)
            {
                return Json(new { Messaggio = messaggio, output = operazioni.Multiplo });
            }
            else
            {
                messaggio = "KO";
                return Json(new { Messaggio = messaggio, output = 0 });
            }
        }
        [HttpGet("Potenza")]
        public JsonResult Potenza(int A, int B)
        {
            string messaggio = "OK";
            var operazioni = new Operazioni();
            operazioni.N1 = A;
            operazioni.N2 = B;
            if (operazioni.N_positivo)
            {
                return Json(new { Messaggio = messaggio, output = operazioni.Potenza()});
            }
            else
            {
                messaggio = "KO";
                return Json(new { Messaggio = messaggio, output = 0 });
            }
        }
        [HttpGet("Anno Bisestile")]
        public JsonResult AnnoBisestile(int A)
        {
            string messaggio = "OK";
            var operazioni = new Operazioni();
            operazioni.N1 = A;
            if (operazioni.N1_positivo)
            {
                return Json(new { Messaggio = messaggio, output = operazioni.AnnoBisestile });
            }
            else
            {
                messaggio = "KO";
                return Json(new { Messaggio = messaggio, output = 0});
            }
        }
        [HttpGet("Ipotenusa")]
        public JsonResult Ipotenusa(int A, int B)
        {
            string messaggio = "OK";
            var operazioni = new Operazioni();
            operazioni.N1 = A;
            operazioni.N2 = B;
            if (operazioni.N_positivo)
            {
                return Json(new { Messaggio = messaggio, output = operazioni.Ipotenusa()});
            }
            else
            {
                messaggio = "KO";
                return Json(new { Messaggio = messaggio, output = 0 });
            }
        }
    }
}
