using DolarApi.EjemploDeHerencia;
using DolarApi.EjercicioAnimalInterfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DolarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HerenciaController : ControllerBase
    {
        [HttpGet]
        public string ObtenerAnimales()
        {
            Delfin delfin = new Delfin("Delfina") { Edad = 15 };
            Jirafa jirafa = new Jirafa("Jirafita") { Altura = 2.69 };

            string animales = $"Delfin: {delfin.Nombre}, Comer: {delfin.Comer()}, Edad: {delfin.Edad} " 
                +
                $"Jirafa: {jirafa.Nombre}, Comer: {jirafa.Comer()}, Altura: {jirafa.Altura}";
            return animales;
        }

    }
}