using Newtonsoft.Json;

namespace AutoMapperSample.Models
{
    public class UdocsContractDto
    {
        [JsonProperty("contract_number")]
        public string CNumber { get; set; }

        [JsonProperty("d_pinfl")]
        public string DirectorPINFL { get; set; }

        [JsonProperty("stir")]
        public int inn { get; set; }
    }
}
