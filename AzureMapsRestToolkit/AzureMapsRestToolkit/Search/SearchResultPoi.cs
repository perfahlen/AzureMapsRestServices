using Newtonsoft.Json;
namespace AzureMapsToolkit.Search
{
    public class SearchResultPoi
    {
        /// <summary>
        /// Categories array
        /// </summary>
        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        /// <summary>
        /// Classification array
        /// </summary>
        [JsonProperty("classifications")]
        public SearchResultPoiClassification[] Classifications { get; set; }

        /// <summary>
        /// Name property
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Phone property
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// URL property
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }


    }
}
