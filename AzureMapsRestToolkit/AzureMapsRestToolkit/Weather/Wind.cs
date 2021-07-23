using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    /// <summary>
    /// Wind details being returned including speed and direction.
    /// </summary>
    public class Wind
    {
        /// <summary>
        /// Wind direction
        /// </summary>
        [JsonPropertyName("direction")]
        public WindDirection Direction { get; set; }

        /// <summary>
        /// Speed of the wind in specified unit.
        /// </summary>
        [JsonPropertyName("speed")]
        public WindSpeed Speed { get; set; }

    }
}
