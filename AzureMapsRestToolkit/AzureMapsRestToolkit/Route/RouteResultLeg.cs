using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Common
{
    public class RouteResultLeg
    {
        /// <summary>
        /// Points array
        /// </summary>
        [JsonPropertyName("points")]
        public Coordinate[] Points { get; set; }

        /// <summary>
        /// Summary object for route section.
        /// </summary>
        [JsonPropertyName("summary")]
        public RouteResultLegSummary Summary { get; set; }
    }
}
