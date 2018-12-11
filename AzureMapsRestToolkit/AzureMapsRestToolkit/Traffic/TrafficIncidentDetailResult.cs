using Newtonsoft.Json;

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
        [JsonProperty("tm")]
        public Tm Tm { get; set; }
    }
}
