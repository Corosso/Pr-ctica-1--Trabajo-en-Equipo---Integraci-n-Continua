using Microsoft.AspNetCore.Mvc;

namespace Practica_1_Integracion_Continua
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Mensaje 2, rama 2";
        }
    }
}
