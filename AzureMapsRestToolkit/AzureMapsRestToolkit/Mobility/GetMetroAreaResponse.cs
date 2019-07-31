using Newtonsoft.Json;

namespace AzureMapsToolkit.Mobility
{
    public class MetroAreaResponse
    {
        [JsonProperty("results")]
        public MetroAreaResult[] Results { get; set; }
    }
}
