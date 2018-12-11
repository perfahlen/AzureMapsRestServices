using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    /// <summary>
    /// The entry point for the POI being returned.
    /// </summary>
    public class SearchResultEntryPoint
    {
        /// <summary>
        /// A location represented as a latitude and longitude.
        /// </summary>
        [JsonProperty("position")]
        public CoordinateAbbreviated Position { get; set; }


        /// <summary>
        /// The type of entry point. Value can be either main or minor.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}