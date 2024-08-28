using Newtonsoft.Json;

namespace EntityMVC.Api
{
    public class ApiNagerDateResponse
    {
        public ApiNagerDateResponse() { }

        public ApiNagerDateResponse(DateTime data, string nomeLocal, string nome, string pais, bool fixo, bool global, List<string> estados, int anoDeLancamento, List<string> tipos)
        {
            Data = data;
            NomeLocal = nomeLocal;
            Nome = nome;
            Pais = pais;
            Fixo = fixo;
            Global = global;
            Estados = estados ?? new List<string>();
            AnoDeLancamento = anoDeLancamento;
            Tipos = tipos ?? new List<string>();
        }

        [JsonProperty("date")]
        public DateTime Data { get; set; }

        [JsonProperty("localName")]
        public string NomeLocal { get; set; } = "NA";

        [JsonProperty("name")]
        public string Nome { get; set; } = "NA";

        [JsonProperty("countryCode")]
        public string Pais { get; set; } = "NA";

        [JsonProperty("fixed")]
        public bool? Fixo { get; set; } = false;

        [JsonProperty("global")]
        public bool? Global { get; set; } = false;

        [JsonProperty("counties")]
        public List<string> Estados { get; set; } = new List<string>();

        [JsonProperty("launchYear")]
        public int? AnoDeLancamento { get; set; } = null;

        [JsonProperty("types")]
        public List<string> Tipos { get; set; } = new List<string>();
    }
}