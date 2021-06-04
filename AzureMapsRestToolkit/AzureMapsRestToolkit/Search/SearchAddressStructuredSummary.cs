using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Search
{
    /// <summary>
    /// Summary object for a Search Address Structured response
    /// </summary>
    public class SearchAddressStructuredSummary : SearchSummary
    { 
        

        /// <summary>
        /// Indication when the internal search engine has applied a geospatial bias to improve the ranking of results. In some methods, this can be affected by setting the lat and lon parameters where available. In other cases it is purely internal.
        /// </summary>
        [JsonPropertyName("geoBias")]
        public SearchSummaryGeoBias GeoBias { get; set; }

        /// <summary>
        /// Maximum number of responses that will be returned
        /// </summary>
        [JsonPropertyName("limit")]
        public int Limit { get; set; }

    }
}
