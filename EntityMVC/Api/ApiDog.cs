
using Azure;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace EntityMVC.Api
{
    public class ApiDog
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

        public static async Task<string> GetDog()
        {
            string dog = null;
            DefinirHeadersHttp();
            response = await client.GetAsync("breeds/image/random");
            if (response.IsSuccessStatusCode)
            {
                string body = await response.Content.ReadAsStringAsync();
                ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(body);
                dog = apiResponse.Message;
            }
            return dog;
        }

    }
}