using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Search
{
    /// <summary>
    /// This object is returned from a successful Search Along Route call.
    /// </summary>
    public class SearchAlongRouteResponse
    {
        /// <summary>
        /// A list of Search Along Route results.
        /// </summary>
        [JsonPropertyName("results")]
        public SearchAlongRouteResult[] Results { get; set; }


        /// <summary>
        /// Summary object for a Search Along Route response
        /// </summary>
        [JsonPropertyName("summary")]
        public SearchSummary Summary { get; set; }
    }
}
