using System.Text.Json;

using System.Text.Json.Serialization;
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
        [JsonPropertyName("formatVersion")]
        public string FormatVersion { get; set; }

        /// <summary>
        /// General Copyrights array
        /// </summary>
        [JsonPropertyName("generalCopyrights")]
        public string[] GeneralCopyrights { get; set; }

        /// <summary>
        /// Regions array
        /// </summary>
        /// 
        [JsonPropertyName("regions")]
        public Region[] Regions { get; set; }
    }
}
