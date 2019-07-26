using Newtonsoft.Json;

namespace AzureMapsToolkit.Mobility
{
    public class GetMetroAreaResponse
    {
        [JsonProperty("results")]
        public MetroAreaResult[] Results { get; set; }
    }
}
