using System.Text.Json;
using System.Text.Json.Serialization;

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
        [JsonPropertyName("label")]
        public string Label { get; set; }
    }
}
