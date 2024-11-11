using DolarApi.EjemploInterfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DolarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Interfaz : ControllerBase
    {
        [HttpGet]
        public string EjemploInterfaz()
        {
            Moto moto = new Moto();
            return moto.Frenar();
        }
    }
}
