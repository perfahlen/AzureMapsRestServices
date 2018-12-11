using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    /// <summary>
    /// This type represents the Search Inside Geometry result object.
    /// </summary>
    public class SearchGeometryResult : SearchResult
    {

        /// <summary>
        /// Entity Type property
        /// </summary>
        [JsonProperty("entityTyp")]
        public string EntityType { get; set; }

        /// <summary>
        /// Info property
        /// </summary>
        [JsonProperty("info")]
        public string Info { get; set; }

    }
}