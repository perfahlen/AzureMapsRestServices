using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    public class SearchNearbySummary : SearchSummary
    {
        /// <summary>
        /// Indication when the internal search engine has applied a geospatial bias to improve the ranking of results. In some methods, this can be affected by setting the lat and lon parameters where available. In other cases it is purely internal.
        /// </summary>
        [JsonProperty("geoBias")]
        public SearchSummaryGeoBias GeoBias { get; set; }
    }
}