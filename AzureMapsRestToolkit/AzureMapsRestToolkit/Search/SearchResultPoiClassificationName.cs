using Newtonsoft.Json;
namespace AzureMapsToolkit.Search
{
    public class SearchResultPoiClassificationName
    {
        /// <summary>
        /// Name property
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }


        /// <summary>
        /// Name Locale property
        /// </summary>
        [JsonProperty("nameLocale")]
        public string NameLocale { get; set; }
    }
}