using System.Net.Http.Headers;

namespace EntityMVC.Api
{
    // API de imagens aleatórias
    public class ApiPicsum
    {
        private static HttpClient client = new HttpClient();
        private static HttpResponseMessage response = new HttpResponseMessage();
        
        private static void DefinirHeadersHttp()
        {
            if (client.BaseAddress == null)
            {
                client.BaseAddress = new Uri("https://picsum.photos/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }
        }

        public static async Task<string> GetPicsumImage()
        {
            string image = null;
            int largura = 300;
            int altura = 200;

            DefinirHeadersHttp();
            response = await client.GetAsync($"{largura}/{altura}");

            if (response.IsSuccessStatusCode)
            {
                // Essa API retorna uma imagem diretamente no ResponseUri
                image = response.RequestMessage.RequestUri.ToString();
            }
            return image;
        }
    }
}