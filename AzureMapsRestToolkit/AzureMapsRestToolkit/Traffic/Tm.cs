using Newtonsoft.Json;

namespace AzureMapsToolkit.Traffic
{
    /// <summary>
    /// Main response element
    /// </summary>
    public class Tm
    {
        /// <summary>
        /// ID of the traffic incident
        /// </summary>
        [JsonProperty("@id")]
        public string Id { get; set; }

        /// <summary>
        /// A single traffic incident, or a cluster of traffic incidents
        /// </summary>
        [JsonProperty("poi")]
        public TrafficIncidentPoi[] Poi { get; set; }
    }
}