using Newtonsoft.Json;

namespace AzureMapsToolkit.Render
{
    /// <summary>
    /// This object is returned from a successful Copyright Tile call
    /// </summary>
    public class CopyrightResult
    {
        /// <summary>
        /// Format Version property
        /// </summary>
        [JsonProperty("formatVersion")]
        public string FormatVersion { get; set; }

        /// <summary>
        /// General Copyrights array
        /// </summary>
        [JsonProperty("generalCopyrights")]
        public string[] GeneralCopyrights { get; set; }

        /// <summary>
        /// Regions array
        /// </summary>
        /// 
        [JsonProperty("regions")]
        public Region[] Regions { get; set; }
    }
}
