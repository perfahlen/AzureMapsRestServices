using Newtonsoft.Json;

namespace AzureMapsToolkit.Common
{
    public class RouteResultSection
    {
        /// <summary>
        /// Delay in seconds caused by the incident.
        /// </summary>
        [JsonProperty("delayInSeconds")]
        public int DelayInSeconds { get; set; }

        /// <summary>
        /// Effective speed of the incident in km/h, averaged over its entire length.
        /// </summary>
        [JsonProperty("effectiveSpeedInKmh")]
        public int EffectiveSpeedInKmh { get; set; }

        /// <summary>
        /// End Point Index property
        /// </summary>
        [JsonProperty("endPointIndex")]
        public int EndPointIndex { get; set; }

        /// <summary>
        /// The magnitude of delay caused by the incident. These values correspond to the values of the response field of the Get Traffic Incident Detail API.
        /// </summary>
        [JsonProperty("magnitudeOfDelay")]
        public MagnitudeOfDelay MagnitudeOfDelay { get; set; }

        /// <summary>
        /// Section Type property
        /// </summary>
        [JsonProperty("sectionType")]
        public string SectionType { get; set; }

        /// <summary>
        /// Type of the incident. Can currently be JAM, ROAD_WORK, ROAD_CLOSURE, or OTHER. See "tec" for detailed information.
        /// </summary>
        [JsonProperty("simpleCategory")]
        public string SimpleCategory { get; set; }

        /// <summary>
        /// Start Point Index property
        /// </summary>
        [JsonProperty("startPointIndex")]
        public int StartPointIndex { get; set; }

        /// <summary>
        /// Details of the traffic event, using definitions in the TPEG2-TEC standard. Can contain and elements.
        /// </summary>
        [JsonProperty("tec")]
        public RouteResultSectionTec Tec { get; set; }

        /// <summary>
        /// Travel Mode property
        /// </summary>
        [JsonProperty("travelMode")]
        public string TravelMode { get; set; }
    }
}
