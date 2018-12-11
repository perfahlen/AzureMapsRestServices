using Newtonsoft.Json;

namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// This object is returned from a successful Route Matrix call. For ex, if 2 origins and 3 destinations are provided, there are going to 2 arrays with 3 elements in each. Each element's content depends on the options provided in the query.
    /// </summary>
    public class RouteMatrixResponse
    {
        /// <summary>
        /// Format Version property
        /// </summary>
        [JsonProperty("formatVersion")]
        public string FormatVersion { get; set; }

        /// <summary>
        /// Results as a 2 dimensional array of route summaries.
        /// </summary>
        [JsonProperty("matrix")]
        public RouteMatrix[][] Matrix { get; set; }

        /// <summary>
        /// Summary object
        /// </summary>
        [JsonProperty("summary")]
        public RouteMatrixSummary Summary { get; set; }

    }
}
