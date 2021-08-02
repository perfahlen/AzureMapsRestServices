using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class DailyIndicesResponse
    {
        [JsonPropertyName("results")]
        public DailyIndex[] Results { get; set; }
    }
}
