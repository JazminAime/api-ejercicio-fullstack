using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json; // Importa Newtonsoft.Json para la deserialización
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Threading.Tasks;

namespace Converter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Converter : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public Converter(HttpClient httpClient) // Constructor que recibe un HttpClient
        {
            _httpClient = httpClient; // Asigna el HttpClient a una variable de instancia
        }

        [HttpGet(Name = "GetQuote")] // Indica que este método responde a solicitudes GET
        public async Task<string> GetQuote([FromQuery] decimal value) // Método que convierte un valor en pesos a dólares
        {
            // Realiza una solicitud a la API "DolarApi" para obtener la cotización
            HttpResponseMessage response = await _httpClient.GetAsync("https://localhost:7260/api/Quote");


            if (!response.IsSuccessStatusCode) // Verifica si la respuesta fue exitosa
            {
                throw new Exception("Error al obtener la cotización"); // Excepción si hay un error
            }

            string quoteJson = await response.Content.ReadAsStringAsync(); // Lee el contenido de la respuesta como texto

            var quoteObject = JsonConvert.DeserializeAnonymousType(quoteJson, new { venta = 0 }); // Deserializa el JSON en un objeto que contiene la propiedad 'venta'

            if (quoteObject == null || quoteObject.venta == 0) // Verifica si la deserialización falló o si la cotización es 0
            {
                throw new Exception("Error al obtener la cotización"); // Excepción si hay un error
            }

            decimal result = quoteObject.venta * value; // Calcula el resultado de la conversión multiplicando la cotización por el valor dado
            return result.ToString("F2"); // Retorna el resultado como un string formateado a dos decimales
        }
    }
}
