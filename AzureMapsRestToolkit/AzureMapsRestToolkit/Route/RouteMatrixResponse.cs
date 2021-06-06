using System.Text.Json;

using System.Text.Json.Serialization;
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
        [JsonPropertyName("formatVersion")]
        public string FormatVersion { get; set; }

        /// <summary>
        /// Results as a 2 dimensional array of route summaries.
        /// </summary>
        [JsonPropertyName("matrix")]
        public RouteMatrix[][] Matrix { get; set; }

        /// <summary>
        /// Summary object
        /// </summary>
        [JsonPropertyName("summary")]
        public RouteMatrixSummary Summary { get; set; }

    }
}
