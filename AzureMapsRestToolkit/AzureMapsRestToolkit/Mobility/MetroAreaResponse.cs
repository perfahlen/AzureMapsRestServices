using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Mobility
{
    public class MetroAreaResponse
    {
        [JsonPropertyName("results")]
        public MetroAreaResult[] Results { get; set; }
    }
}
