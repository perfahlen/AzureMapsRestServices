using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AzureMapsToolkit.Mobility
{
    public class TransitTypeResult
    {
        /// <summary>
        /// For metro areas in which local name is different than the GFTS supported transit type, original name is returned.
        /// </summary>
        [JsonProperty("captionOverride")]
        public string CaptionOverride { get; set; }

        /// <summary>
        /// Supported public transit type.
        /// </summary>
        [JsonProperty("transitType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TransitType TransitType { get; set; }
    }
}