using Microsoft.AspNetCore.Mvc;

namespace Practica_1_Integracion_Continua
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Cambio1 para generar conflicto";
        }
    }
}
