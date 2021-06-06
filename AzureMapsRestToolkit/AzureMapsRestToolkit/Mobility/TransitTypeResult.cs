using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Mobility
{
    public class TransitTypeResult
    {
        /// <summary>
        /// For metro areas in which local name is different than the GFTS supported transit type, original name is returned.
        /// </summary>
        [JsonPropertyName("captionOverride")]
        public string CaptionOverride { get; set; }

        /// <summary>
        /// Supported public transit type.
        /// </summary>
        [JsonPropertyName("transitType")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TransitType TransitType { get; set; }
    }
}