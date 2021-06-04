using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Common
{
    public class RouteResultSection
    {
        /// <summary>
        /// Delay in seconds caused by the incident.
        /// </summary>
        [JsonPropertyName("delayInSeconds")]
        public int DelayInSeconds { get; set; }

        /// <summary>
        /// Effective speed of the incident in km/h, averaged over its entire length.
        /// </summary>
        [JsonPropertyName("effectiveSpeedInKmh")]
        public int EffectiveSpeedInKmh { get; set; }

        /// <summary>
        /// End Point Index property
        /// </summary>
        [JsonPropertyName("endPointIndex")]
        public int EndPointIndex { get; set; }

        /// <summary>
        /// The magnitude of delay caused by the incident. These values correspond to the values of the response field of the Get Traffic Incident Detail API.
        /// </summary>
        [JsonPropertyName("magnitudeOfDelay")]
        public MagnitudeOfDelay MagnitudeOfDelay { get; set; }

        /// <summary>
        /// Section Type property
        /// </summary>
        [JsonPropertyName("sectionType")]
        public string SectionType { get; set; }

        /// <summary>
        /// Type of the incident. Can currently be JAM, ROAD_WORK, ROAD_CLOSURE, or OTHER. See "tec" for detailed information.
        /// </summary>
        [JsonPropertyName("simpleCategory")]
        public string SimpleCategory { get; set; }

        /// <summary>
        /// Start Point Index property
        /// </summary>
        [JsonPropertyName("startPointIndex")]
        public int StartPointIndex { get; set; }

        /// <summary>
        /// Details of the traffic event, using definitions in the TPEG2-TEC standard. Can contain and elements.
        /// </summary>
        [JsonPropertyName("tec")]
        public RouteResultSectionTec Tec { get; set; }

        /// <summary>
        /// Travel Mode property
        /// </summary>
        [JsonPropertyName("travelMode")]
        public string TravelMode { get; set; }
    }
}
