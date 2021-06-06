using System.Text.Json;

using System.Text.Json.Serialization;
namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// A location represented as a latitude and longitude.
    /// </summary>
    public class Coordinate
    {
        /// <summary>
        /// Latitude property
        /// </summary>
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// Longitude property
        /// </summary>
        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }
    }
}
