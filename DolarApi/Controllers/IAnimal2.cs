using DolarApi.EjercicioAnimalInterfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DolarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IAnimal2 : ControllerBase
    {
        [HttpGet]
        public string InterfazAnimal()
        {
            Gato gato = new Gato();
            Perro perro = new Perro();
            gato.Comer();
            return perro.Dormir();
           

        }
    }
}
