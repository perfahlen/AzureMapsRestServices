using System.Text.Json.Serialization;

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
        [JsonPropertyName("position")]
        public CoordinateAbbreviated Position { get; set; }


        /// <summary>
        /// The type of entry point. Value can be either main or minor.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}