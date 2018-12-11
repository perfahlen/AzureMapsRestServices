using Newtonsoft.Json;

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
        [JsonProperty("lat")]
        public double Lat { get; set; }

        /// <summary>
        /// Longitude property
        /// </summary>
        [JsonProperty("lon")]
        public double Lon { get; set; }
    }
}