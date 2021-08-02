using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class WeatherUnit
    {
        /// <summary>
        /// Type of unit for the returned value.
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Numeric ID value associated with the type of unit being displayed. Can be used for unit translation. Please refer to Weather Service Concepts for details.
        /// </summary>
        [JsonPropertyName("unitType")]
        public int UnitType { get; set; }

        /// <summary>
        /// Rounded value.
        /// </summary>
        [JsonPropertyName("value")]
        public double Value { get; set; }


    }
}