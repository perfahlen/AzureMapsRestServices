using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class CurrentConditionsResponse
    {
        [JsonPropertyName("results")]
        public CurrentConditions[] Results { get; set; }
    }

}
