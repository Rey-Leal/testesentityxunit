using Newtonsoft.Json;

namespace EntityMVC.Api
{
    public class ApiDogCeoResponse
    {
        public ApiDogCeoResponse() { }

        public ApiDogCeoResponse(string message, string status)
        {
            Message = message;
            Status = status;
        }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}