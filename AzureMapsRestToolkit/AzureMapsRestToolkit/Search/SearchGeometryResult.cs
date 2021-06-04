using System.Text.Json.Serialization;

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
        [JsonPropertyName("entityTyp")]
        public string EntityType { get; set; }

        /// <summary>
        /// Info property
        /// </summary>
        [JsonPropertyName("info")]
        public string Info { get; set; }

    }
}