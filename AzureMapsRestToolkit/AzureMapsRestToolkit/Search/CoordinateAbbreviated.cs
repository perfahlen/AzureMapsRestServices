using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Search
{
    /// <summary>
    /// A location represented as a latitude and longitude.
    /// </summary>
    public class CoordinateAbbreviated
    {
        /// <summary>
        /// Latitude property
        /// </summary>
        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        /// <summary>
        /// Longitude property
        /// </summary>
        [JsonPropertyName("lon")]
        public double Lon { get; set; }
    }
}