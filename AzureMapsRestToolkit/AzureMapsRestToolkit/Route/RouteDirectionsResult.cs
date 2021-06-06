using System.Text.Json;

using System.Text.Json.Serialization;
namespace AzureMapsToolkit.Common
{
    public class RouteDirectionsResult
    {
        /// <summary>
        /// Contains guidance related elements. This field is present only when guidance was requested and is available.
        /// </summary>
        [JsonPropertyName("guidance")]
        public RouteResultGuidance Guidance { get; set; }

        /// <summary>
        /// Legs array
        /// </summary>
        [JsonPropertyName("legs")]
        public RouteResultLeg[] Legs { get; set; }

        /// <summary>
        /// Sections array
        /// </summary>
        [JsonPropertyName("sections")]
        public RouteResultSection[] Sections { get; set; }

        /// <summary>
        /// Summary object
        /// </summary>
        [JsonPropertyName("summary")]
        public RouteDirectionsSummary Summary { get; set; }
    }
}
