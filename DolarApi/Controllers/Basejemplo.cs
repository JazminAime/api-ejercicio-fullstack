using DolarApi.EjercicioAnimalInterfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DolarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Basejemplo : ControllerBase
    {
        [HttpGet]
        public string InterfazAnimal()
        {
            Base _base = new Base();
            Perro perro = new Perro();
            return _base.Comer(perro);
        }
    }
}
