using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Timezone
{
    public class IanaId
    {
        /// <summary>
        /// AliasOf property
        /// </summary>
        [JsonPropertyName("aliasOf")]
        public string AliasOf { get; set; }


        /// <summary>
        /// HasZone1970Location property
        /// </summary>
        [JsonPropertyName("hasZone1970Location")]
        public bool HasZone1970Location { get; set; }

        /// <summary>
        /// Id property
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// IsAlias property
        /// </summary>
        [JsonPropertyName("isAlias")]
        public bool IsAlias { get; set; }
    }
}
