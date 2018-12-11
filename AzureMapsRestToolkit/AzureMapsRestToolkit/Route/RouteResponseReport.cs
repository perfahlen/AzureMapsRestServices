using Newtonsoft.Json;

namespace AzureMapsToolkit.Common
{

    /// <summary>
    /// Reports the effective settings used in the current call.
    /// </summary>
    public class RouteResponseReport
    {
        /// <summary>
        /// Effective parameters or data used when calling this Route API.
        /// </summary>
        [JsonProperty("effectiveSettings")]
        public RouteResponseReportEffectiveSetting[] EffectiveSettings { get; set; }
    }
}
