using System.Text.Json.Serialization;
namespace AzureMapsToolkit.Search
{
    public class SearchResultPoi
    {
        /// <summary>
        /// Categories array
        /// </summary>
        [JsonPropertyName("categories")]
        public string[] Categories { get; set; }

        /// <summary>
        /// Classification array
        /// </summary>
        [JsonPropertyName("classifications")]
        public SearchResultPoiClassification[] Classifications { get; set; }

        /// <summary>
        /// Name property
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Phone property
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// URL property
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }


    }
}
