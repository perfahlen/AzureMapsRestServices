using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class WeatherAlongRoutePrecipitation
    {
        /// <summary>
        /// The forecasted precipitation intensity in dBZ (decibels relative to Z) from 0.0 to 100.0.
        /// </summary>
        [JsonPropertyName("dbz")]
        public double Dbz { get; set; }

        /// <summary>
        /// Precipitation type.If precipitation should occur, the type that it will be: "RAIN," "HAIL," "SNOW," "ICE," or "MIX."
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}