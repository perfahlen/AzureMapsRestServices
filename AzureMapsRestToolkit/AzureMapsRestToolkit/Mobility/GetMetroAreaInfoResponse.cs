using Newtonsoft.Json;

namespace AzureMapsToolkit.Mobility
{
    public class GetMetroAreaInfoResponse
    {
        /// <summary>
        /// Details of the agency.
        /// </summary>
        [JsonProperty("agencies")]
        public Agency[] Agencies { get; set; }

        /// <summary>
        /// Basic information associated with the active alert.
        /// </summary>
        [JsonProperty("alerts")]
        public Alert[] Alerts { get; set; }

        /// <summary>
        /// The name of the metro area.
        /// </summary>
        [JsonProperty("metroName")]
        public string MetroName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("transitTypes")]
        public TransitTypeResult[] TransitTypes { get; set; }
    }
}
