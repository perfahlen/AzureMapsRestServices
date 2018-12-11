using Newtonsoft.Json;

namespace AzureMapsToolkit.Render
{
    /// <summary>
    /// Country property
    /// </summary>
    public class Country
    {
        /// <summary>
        /// ISO3 property
        /// </summary>
        public string ISO3 { get; set; }

        /// <summary>
        /// Label property
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }
    }
}
