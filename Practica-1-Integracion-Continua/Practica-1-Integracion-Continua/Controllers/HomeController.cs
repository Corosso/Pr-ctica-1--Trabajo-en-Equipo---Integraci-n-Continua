using Microsoft.AspNetCore.Mvc;

namespace Practica_1_Integracion_Continua
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Nuevo mensaje de simulación de error";
        }
    }
}
