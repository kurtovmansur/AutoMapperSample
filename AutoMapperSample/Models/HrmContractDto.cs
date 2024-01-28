using Newtonsoft.Json;

namespace AutoMapperSample.Models
{
    public class HrmContractDto
    {
        public Guid Id { get; set; }
        
        [JsonProperty("contract_number")]
        public string ContractNumber{get;set;}

        [JsonProperty("DirectorPinfl")]
        public string DirectorPinfl { get; set; }

        [JsonProperty("Tin")]
        public string Tin { get; set; }
    }
}
