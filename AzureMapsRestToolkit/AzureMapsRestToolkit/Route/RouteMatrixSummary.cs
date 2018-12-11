using Newtonsoft.Json;

namespace AzureMapsToolkit.Common
{
    public class RouteMatrixSummary
    {
        /// <summary>
        /// Number of successful routes in the response.
        /// </summary>
        [JsonProperty("successfulRoutes ")]
        public int SuccessfulRoutes { get; set; }

        /// <summary>
        /// Total number of routes requested. Number of cells in the input matrix.
        /// </summary>
        [JsonProperty("TotalRoutes")]
        public int TotalRoutes { get; set; }
    }
}
