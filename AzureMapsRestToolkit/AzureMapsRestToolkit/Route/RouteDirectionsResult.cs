using Newtonsoft.Json;

namespace AzureMapsToolkit.Common
{
    public class RouteDirectionsResult
    {
        /// <summary>
        /// Contains guidance related elements. This field is present only when guidance was requested and is available.
        /// </summary>
        [JsonProperty("guidance")]
        public RouteResultGuidance Guidance { get; set; }

        /// <summary>
        /// Legs array
        /// </summary>
        [JsonProperty("legs")]
        public RouteResultLeg[] Legs { get; set; }

        /// <summary>
        /// Sections array
        /// </summary>
        [JsonProperty("sections")]
        public RouteResultSection[] Sections { get; set; }

        /// <summary>
        /// Summary object
        /// </summary>
        [JsonProperty("summary")]
        public RouteDirectionsSummary Summary { get; set; }
    }
}
