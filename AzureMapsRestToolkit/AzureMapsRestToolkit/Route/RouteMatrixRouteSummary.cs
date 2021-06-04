using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Common
{
    public class RouteMatrixRouteSummary
    {
        [JsonPropertyName("routeSummary")]
        public RouteMatrixResponseSummary RouteSummary { get; set; }
    }
}
