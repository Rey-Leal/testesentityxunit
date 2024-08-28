using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace EntityMVC.Api
{
    // API de imagens aleatórias de cães
    public class ApiDogCeo
    {
        private static HttpClient client = new HttpClient();
        private static HttpResponseMessage response = new HttpResponseMessage();

        private static void DefinirHeadersHttp()
        {
            if (client.BaseAddress == null)
            {
                client.BaseAddress = new Uri("https://dog.ceo/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }
        }

        public static async Task<string> GetDogImage()
        {
            string image = null;

            try
            {
                DefinirHeadersHttp();
                response = await client.GetAsync("breeds/image/random");

                if (response.IsSuccessStatusCode)
                {
                    // Essa API retorna message e status
                    string json = await response.Content.ReadAsStringAsync();
                    ApiDogCeoResponse apiDogCeoResponse = JsonConvert.DeserializeObject<ApiDogCeoResponse>(json);
                    image = apiDogCeoResponse.Message;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return image;
        }

    }
}