
using Newtonsoft.Json;

namespace EntityMVC.Api
{
    public class ApiDogCeoResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}