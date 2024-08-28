using Newtonsoft.Json;

namespace EntityMVC.Api
{
    public class ApiConsultaCepResponse
    {
        public ApiConsultaCepResponse() { }

        public ApiConsultaCepResponse(string cep, string logradouro, string complemento, string unidade, string bairro, string cidade, string uf, string ibge, string gia, string ddd, string siafi)
        {
            Cep = cep;
            Logradouro = logradouro;
            Complemento = complemento;
            Unidade = unidade;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            IBGE = ibge;
            Gia = gia;
            DDD = ddd;
            Siafi = siafi;
        }

        [JsonProperty("cep")]
        public String Cep { get; set; } = "NA";

        [JsonProperty("logradouro")]
        public String Logradouro { get; set; } = "NA";

        [JsonProperty("complemento")]
        public String Complemento { get; set; } = "NA";

        [JsonProperty("unidade")]
        public String Unidade { get; set; } = "NA";

        [JsonProperty("bairro")]
        public String Bairro { get; set; } = "NA";

        [JsonProperty("localidade")]
        public String Cidade { get; set; } = "NA";

        [JsonProperty("uf")]
        public String Uf { get; set; } = "NA";

        [JsonProperty("ibge")]
        public String IBGE { get; set; } = "NA";

        [JsonProperty("gia")]
        public String Gia { get; set; } = "NA";

        [JsonProperty("ddd")]
        public String DDD { get; set; } = "NA";

        [JsonProperty("siafi")]
        public String Siafi { get; set; } = "NA";
    }
}