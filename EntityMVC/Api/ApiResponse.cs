
using Newtonsoft.Json;

namespace EntityMVC.Api
{
    public class ApiResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}