using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Render
{
    public class Region
    {
        /// <summary>
        /// Copyrights array
        /// </summary>
        [JsonPropertyName("copyrights")]
        public string[] Copyrights { get; set; }

        /// <summary>
        /// Country property
        /// </summary>
        [JsonPropertyName("country")]
        public Country Country { get; set; }
    }
}
