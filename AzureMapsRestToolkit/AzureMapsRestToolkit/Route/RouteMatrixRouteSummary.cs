using Newtonsoft.Json;

namespace AzureMapsToolkit.Common
{
    public class RouteMatrixRouteSummary
    {
        [JsonProperty("routeSummary")]
        public RouteMatrixResponseSummary RouteSummary { get; set; }
    }
}
