using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class PastHours
    {
        /// <summary>
        /// maximum
        /// </summary>
        [JsonPropertyName("maximum")]
        public WeatherUnit Maximum { get; set; }

        /// <summary>
        /// minimum
        /// </summary>
        [JsonPropertyName("minimum")]
        public WeatherUnit Minimum { get; set; }
    }
}