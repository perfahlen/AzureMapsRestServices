using Newtonsoft.Json;

namespace AzureMapsToolkit.Timezone
{
    /// <summary>
    /// This object is returned from a successful Timezone IANA Version call
    /// </summary>
    public class TimezoneIanaVersionResult
    {
        /// <summary>
        /// Version property
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
