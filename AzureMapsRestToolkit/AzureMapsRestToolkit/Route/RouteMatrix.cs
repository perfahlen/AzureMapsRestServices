using System.Text.Json;

using System.Text.Json.Serialization;
namespace AzureMapsToolkit.Common
{
    public class RouteMatrix
    {
        [JsonPropertyName("statusCode")]
        public int StatusCode { get; set; }

        [JsonPropertyName("response")]
        public RouteMatrixRouteSummary Response { get; set; }
    }
}
