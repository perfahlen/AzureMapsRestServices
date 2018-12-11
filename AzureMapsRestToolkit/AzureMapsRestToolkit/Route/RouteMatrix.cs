using Newtonsoft.Json;

namespace AzureMapsToolkit.Common
{
    public class RouteMatrix
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("response")]
        public RouteMatrixRouteSummary Response { get; set; }
    }
}
