using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace EntityMVC.Api
{
    // API de feriados nacionais
    public class ApiConsultaCep
    {
        private static HttpClient client = new HttpClient();
        private static HttpResponseMessage response = new HttpResponseMessage();

        private static void DefinirHeadersHttp()
        {
            if (client.BaseAddress == null)
            {
                client.BaseAddress = new Uri("https://date.nager.at/api/v3/PublicHolidays/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }
        }

        public static async Task<List<ApiNagerDateResponse>> GetEndereco(int ano)
        {
            List<ApiNagerDateResponse> feriados = new List<ApiNagerDateResponse>();
            string pais = "BR";

            DefinirHeadersHttp();
            response = await client.GetAsync($"{ano}/{pais}");

            if (response.IsSuccessStatusCode)
            {
                // Essa API retorna um corpo completo com tipo ApiNagerDateResponse
                var json = await response.Content.ReadAsStringAsync();
                feriados = JsonConvert.DeserializeObject<List<ApiNagerDateResponse>>(json) ?? new List<ApiNagerDateResponse>();
            }
            return feriados;
        }

    }
}