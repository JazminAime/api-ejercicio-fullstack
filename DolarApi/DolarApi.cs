using System.Net.Http.Headers;

namespace DolarApi
{
    public class DolarApi
    {
        public async Task<string> GetQuote() // Método que obtiene la cotización del dólar de forma asincrónica
        {
            string responseBody = string.Empty; // Inicializa una variable para almacenar la respuesta
            using (var client = new HttpClient()) // Crea un cliente HTTP para hacer solicitudes
            {
                client.BaseAddress = new Uri("https://dolarapi.com/v1/dolares/blue"); // Establece la URL base para las solicitudes
                client.DefaultRequestHeaders.Accept.Clear(); // Limpia los encabezados
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); // Se espera una respuesta en formato JSON

                HttpResponseMessage response = await client.GetAsync(client.BaseAddress); // Hace una solicitud GET a la URL
                response.EnsureSuccessStatusCode(); // Verifica que la respuesta sea exitosa

                responseBody = await response.Content.ReadAsStringAsync(); // Lee el contenido de la respuesta como texto
            }
            return responseBody; // Devuelve el contenido de la respuesta
        }

        public async Task<string> GetSpecificQuote(Currency currency) // Método que obtiene la cotización de un tipo específico de dólar
        {
            string responseBody = string.Empty; // Inicializa una variable para almacenar la respuesta

            using (var client = new HttpClient()) // Crea un cliente HTTP para hacer solicitudes
            {
                // Construye la URL para obtener la cotización específica según el tipo de moneda
                client.BaseAddress = new Uri($"https://dolarapi.com/v1/dolares/{currency.Code}");
                client.DefaultRequestHeaders.Accept.Clear(); // Limpia los encabezados
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); // Se espera una respuesta en formato JSON

                HttpResponseMessage response = await client.GetAsync(client.BaseAddress); // Hace una solicitud GET a la URL
                response.EnsureSuccessStatusCode(); // Verifica que la respuesta sea exitosa

                responseBody = await response.Content.ReadAsStringAsync(); // Lee el contenido de la respuesta como texto
            }

            return responseBody; // Devuelve el contenido de la respuesta
        }
    }
}