using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class WeatherAlongRouteSummary
    {
        [JsonPropertyName("hazards")]
        public Hazards Hazards { get; set; }

        /// <summary>
        /// Numeric value representing an image that displays the iconPhrase. Please refer to Weather Service Concepts for details.
        /// </summary>
        [JsonPropertyName("iconCode")]
        public int IconCode { get; set; }
    }
}
