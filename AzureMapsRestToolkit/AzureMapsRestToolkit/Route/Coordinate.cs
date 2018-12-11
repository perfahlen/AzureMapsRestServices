using Newtonsoft.Json;

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
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// Longitude property
        /// </summary>
        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }
}
