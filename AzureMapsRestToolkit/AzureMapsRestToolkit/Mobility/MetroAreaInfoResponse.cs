using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Mobility
{
    public class MetroAreaInfoResponse
    {
        /// <summary>
        /// Details of the agency.
        /// </summary>
        [JsonPropertyName("agencies")]
        public Agency[] Agencies { get; set; }

        /// <summary>
        /// Basic information associated with the active alert.
        /// </summary>
        [JsonPropertyName("alerts")]
        public Alert[] Alerts { get; set; }

        /// <summary>
        /// The name of the metro area.
        /// </summary>
        [JsonPropertyName("metroName")]
        public string MetroName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("transitTypes")]
        public TransitTypeResult[] TransitTypes { get; set; }
    }
}
