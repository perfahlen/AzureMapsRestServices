using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Common
{
    public class RouteMatrixSummary
    {
        /// <summary>
        /// Number of successful routes in the response.
        /// </summary>
        [JsonPropertyName("successfulRoutes ")]
        public int SuccessfulRoutes { get; set; }

        /// <summary>
        /// Total number of routes requested. Number of cells in the input matrix.
        /// </summary>
        [JsonPropertyName("totalRoutes")]
        public int TotalRoutes { get; set; }
    }
}
