using System.Text.Json.Serialization;

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
        [JsonPropertyName("@id")]
        public string Id { get; set; }

        /// <summary>
        /// A single traffic incident, or a cluster of traffic incidents
        /// </summary>
        [JsonPropertyName("poi")]
        public TrafficIncidentPoi[] Poi { get; set; }
    }
}