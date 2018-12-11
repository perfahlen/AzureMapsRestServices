using Newtonsoft.Json;

namespace AzureMapsToolkit.Timezone
{
    public class IanaId
    {
        /// <summary>
        /// AliasOf property
        /// </summary>
        [JsonProperty("aliasOf")]
        public string AliasOf { get; set; }


        /// <summary>
        /// HasZone1970Location property
        /// </summary>
        [JsonProperty("hasZone1970Location")]
        public bool HasZone1970Location { get; set; }

        /// <summary>
        /// Id property
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// IsAlias property
        /// </summary>
        [JsonProperty("isAlias")]
        public bool IsAlias { get; set; }
    }
}
