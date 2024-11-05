using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DolarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        [HttpGet(Name = "GetQuote")] // Indica que este método responde a solicitudes GET
        public async Task<string> GetQuote() // Método que obtiene la cotización del dólar
        {
            DolarApi api = new DolarApi(); // Crea una instancia de DolarAPI
            return await api.GetQuote(); // Llama al método GetQuote y devuelve su resultado
        }

        [HttpPost(Name = "GetSpecificQuote")] // Indica que este método responde a solicitudes POST
        public async Task<string> GetSpecificQuote([FromBody] Currency currency) // Método que obtiene la cotización de un tipo específico de dólar
        {
            DolarApi api = new DolarApi(); // Crea una instancia de DolarAPI
            return await api.GetSpecificQuote(currency); // Llama al método GetSpecificQuote y devuelve su resultado
        }
    }
}