using Newtonsoft.Json;

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
        [JsonProperty("results")]
        public SearchGeometryResult[] Results { get; set; }

        /// <summary>
        /// Summary object for a Search Geometry response
        /// </summary>
        [JsonProperty("summary")]
        public SearchSummary Summary { get; set; }
    }
}
