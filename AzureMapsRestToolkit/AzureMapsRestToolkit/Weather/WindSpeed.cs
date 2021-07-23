using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    /// <summary>
    /// Speed of wind in specified unit.
    /// </summary>
    public class WindSpeed
    {
        /// <summary>
        /// Type of unit for the speed value.
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Numeric ID value associated with the type of unit being displayed. Can be used for unit translation. Please refer to Weather Service Concepts for details.
        /// </summary>
        [JsonPropertyName("unitType")]
        public int UnitType { get; set; }

        /// <summary>
        /// Rounded value of the speed.
        /// </summary>
        [JsonPropertyName("value")]
        public double Value { get; set; }
    }
}