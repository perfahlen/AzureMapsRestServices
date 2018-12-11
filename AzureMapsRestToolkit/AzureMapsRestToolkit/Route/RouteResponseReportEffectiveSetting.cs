using Newtonsoft.Json;

namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// Effective parameter or data used when calling this Route API.
    /// </summary>
    public class RouteResponseReportEffectiveSetting
    {
        /// <summary>
        /// Name of the parameter used.
        /// </summary>
        [JsonProperty("Name of the parameter used.")]
        public string Key { get; set; }

        /// <summary>
        /// Value of the parameter used.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

    }
}
