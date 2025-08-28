using Microsoft.AspNetCore.Mvc;

namespace Practica_1_Integracion_Continua
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Mensaje 1, rama 1";
        }
    }
}
