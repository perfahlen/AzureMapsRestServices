using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Search
{
    /// <summary>
    /// A list of Search Inside Geometry results.
    /// </summary>
    public class SearchGeometryResponse
    {
        /// <summary>
        /// A list of Search Inside Geometry results.
        /// </summary>
        [JsonPropertyName("results")]
        public SearchGeometryResult[] Results { get; set; }

        /// <summary>
        /// Summary object for a Search Geometry response
        /// </summary>
        [JsonPropertyName("summary")]
        public SearchSummary Summary { get; set; }
    }
}
