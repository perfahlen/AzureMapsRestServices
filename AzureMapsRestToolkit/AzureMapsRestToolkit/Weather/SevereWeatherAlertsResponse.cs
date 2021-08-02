using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class SevereWeatherAlertsResponse
    {
        [JsonPropertyName("SevereWeatherAlert")]
        public SevereWeatherAlert SevereWeatherAlert { get; set; }
    }
}
