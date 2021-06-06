using System.Text.Json;
using System.Text.Json.Serialization;

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
        [JsonPropertyName("Name of the parameter used.")]
        public string Key { get; set; }

        /// <summary>
        /// Value of the parameter used.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }

    }
}
