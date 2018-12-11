using Newtonsoft.Json;

namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// Details of the traffic event, using definitions in the TPEG2-TEC standard. Can contain and elements.
    /// </summary>
    public class RouteResultSectionTec
    {
        /// <summary>
        /// The effect on the traffic flow. Contains a value in the tec001:EffectCode table, as defined in the TPEG2-TEC standard. Can be used to color-code traffic events according to severity.
        /// </summary>
        [JsonProperty("effectCode")]
        public int EffectCode { get; set; }

        /// <summary>
        /// List of elements.
        /// </summary>
        [JsonProperty("causes")]
        public RouteResultSectionTecCause[] Causes { get; set; }
    }
}
