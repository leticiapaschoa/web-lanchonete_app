using Newtonsoft.Json;

namespace WebApplication.Models.Entity
{
    public class Mensagem
    {
        [JsonProperty("user")]
        public string user { get; set; }
        [JsonProperty("txt")]
        public string txt { get; set; }
    }
}