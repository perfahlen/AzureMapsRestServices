using System.Text.Json.Serialization;

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
        [JsonPropertyName("Version")]
        public string Version { get; set; }
    }
}
