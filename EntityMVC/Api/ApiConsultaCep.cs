using Newtonsoft.Json;
using NuGet.Common;
using System.Net.Http.Headers;

namespace EntityMVC.Api
{
    // API de consulta de Endereços via CEP
    public class ApiConsultaCep
    {
        private static HttpClient client = new HttpClient();
        private static HttpResponseMessage response = new HttpResponseMessage();

        private static void DefinirHeadersHttp()
        {
            if (client.BaseAddress == null)
            {
                client.BaseAddress = new Uri("https://viacep.com.br/ws/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }
        }

        public static async Task<ApiConsultaCepResponse> GetEndereco(string cep)
        {
            ApiConsultaCepResponse endereco = new ApiConsultaCepResponse();
            
            try
            {
                DefinirHeadersHttp();                                
                response = await client.GetAsync($"consulta/cep/{cep}");

                if (response.IsSuccessStatusCode)
                {
                    // Essa API retorna um corpo completo com tipo ApiConsultaCepResponse
                    var json = await response.Content.ReadAsStringAsync();
                    endereco = JsonConvert.DeserializeObject<ApiConsultaCepResponse>(json) ?? new ApiConsultaCepResponse();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return endereco;
        }

    }
}