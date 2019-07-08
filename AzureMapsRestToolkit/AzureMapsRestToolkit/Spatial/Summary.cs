using Newtonsoft.Json;

namespace AzureMapsToolkit.Spatial
{
    /// <summary>
    /// Summary of the call.
    /// </summary>
    public class Summary
    {
        /// <summary>
        /// The information about what happened during the call.
        /// </summary>
        [JsonProperty("information")]
        public string Information { get; set; }

        /// <summary>
        /// The udid for the user data if one exists
        /// </summary>
        [JsonProperty("udid")]
        public string Udid { get; set; }
    }
}
