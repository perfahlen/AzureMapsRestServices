using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    /// <summary>
    /// Returned temperature values.
    /// </summary>
    public class WeatherUnitRange
    {
        /// <summary>
        /// Maximum temperature for the time period
        /// </summary>
        [JsonPropertyName("maximum")]
        public WeatherUnit Maximum { get; set; }

        /// <summary>
        /// Minimum temperature for the time period.
        /// </summary>
        [JsonPropertyName("minimum")]
        public WeatherUnit Minimum { get; set; }
    }
}