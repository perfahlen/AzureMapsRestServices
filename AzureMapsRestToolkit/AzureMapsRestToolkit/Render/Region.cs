using Newtonsoft.Json;

namespace AzureMapsToolkit.Render
{
    public class Region
    {
        /// <summary>
        /// Copyrights array
        /// </summary>
        [JsonProperty("copyrights")]
        public string[] Copyrights { get; set; }

        /// <summary>
        /// Country property
        /// </summary>
        [JsonProperty("country")]
        public Country Country { get; set; }
    }
}
