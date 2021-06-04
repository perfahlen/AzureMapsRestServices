using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Traffic
{
    public class TrafficIncidentPoi
    {
        /// <summary>
        /// Cause of the incident, where available, in the language requested
        /// </summary>
        [JsonPropertyName("c")]
        public string C { get; set; }

        /// <summary>
        /// Bottom left coordinate of the cluster in the projection of the request
        /// </summary>
        [JsonPropertyName("cbl")]
        public Point Cbl { get; set; }

        /// <summary>
        /// Cluster size: the number of incidents in the cluster
        /// </summary>
        [JsonPropertyName("cs")]
        public int? Cs { get; set; }

        /// <summary>
        /// Top right coordinate of the cluster in the projection of the request
        /// </summary>
        [JsonPropertyName("ctr")]
        public Point Ctr { get; set; }

        /// <summary>
        /// Description of the incident in the language requested
        /// </summary>
        [JsonPropertyName("d")]
        public string D { get; set; }

        /// <summary>
        /// Delay caused by the incident in seconds (except in road closures)
        /// </summary>
        [JsonPropertyName("dl")]
        public int? Dl { get; set; }

        /// <summary>
        /// From: the name of the intersection or location where the traffic due to the incident starts
        /// </summary>
        [JsonPropertyName("f")]
        public string F { get; set; }

        /// <summary>
        /// The icon category associated with this incident. Values are numbers in the range 0-13, with the following meanings
        /// </summary>
        [JsonPropertyName("ic")]
        public int? IC { get; set; }

        /// <summary>
        /// ID of the traffic incident
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The point where an icon of the cluster or raw incident should be drawn, expressed in the requested projection. This is affected by traffic style, zoom level and road type
        /// </summary>
        [JsonPropertyName("p")]
        public Point P { get; set; }

        /// <summary>
        /// The road number(s) affected by the incident. Multiple road numbers will delimited by slashes
        /// </summary>
        [JsonPropertyName("r")]
        public string R { get; set; }

        /// <summary>
        /// To: the name of the intersection or location where the traffic due to the incident ends
        /// </summary>
        [JsonPropertyName("t")]
        public string T { get; set; }

        /// <summary>
        /// The magnitude of delay associated with incident. These values correspond to incident colors in the traffic tiles
        /// </summary>
        [JsonPropertyName("ty")]
        public int? Ty { get; set; }
    }
}