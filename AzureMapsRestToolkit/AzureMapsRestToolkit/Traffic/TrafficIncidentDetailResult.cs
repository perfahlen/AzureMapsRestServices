using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Traffic
{
    /// <summary>
    /// This object is returned from a successful Traffic incident Detail call
    /// </summary>
    public class TrafficIncidentDetailResult
    {
        /// <summary>
        /// Main response element
        /// </summary>
        [JsonPropertyName("tm")]
        public Tm Tm { get; set; }
    }
}
