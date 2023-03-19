using Newtonsoft.Json;

namespace IECReportGenreator.Models
{
    public class IECModel
    {
        [JsonProperty("class")]
        public string Class { get; set; }
        [JsonProperty("height")]
        public decimal Height { get; set; }
        [JsonProperty("power")]
        public string Power { get; set; }
        [JsonProperty("rotorDiameter")]
        public int RotorDiameter { get; set; }
    }
}
