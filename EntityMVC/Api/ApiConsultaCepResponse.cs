using Newtonsoft.Json;

namespace EntityMVC.Api
{
    public class ApiConsultaCepResponse
    {
        public ApiConsultaCepResponse() { }

        public ApiConsultaCepResponse(string cep, string tipoCep, string subTipoCep, string uf, string cidade, string bairro, string endereco, string complemento, string codigoIBGE)
        {
            Cep = cep;
            TipoCep = tipoCep;
            SubTipoCep = subTipoCep;
            Uf = uf;
            Cidade = cidade;
            Bairro = bairro;
            Endereco = endereco;
            Complemento = complemento;
            CodigoIBGE = codigoIBGE;
        }

        [JsonProperty("cep")]
        public String Cep { get; set; }

        [JsonProperty("tipoCep")]
        public String TipoCep { get; set; }

        [JsonProperty("subTipoCep")]
        public String SubTipoCep { get; set; }

        [JsonProperty("uf")]
        public String Uf { get; set; }

        [JsonProperty("cidade")]
        public String Cidade { get; set; }

        [JsonProperty("bairro")]
        public String Bairro { get; set; }

        [JsonProperty("endereco")]
        public String Endereco { get; set; }

        [JsonProperty("complemento")]
        public String Complemento { get; set; }

        [JsonProperty("codigoIBGE")]
        public String CodigoIBGE { get; set; }
    }
}