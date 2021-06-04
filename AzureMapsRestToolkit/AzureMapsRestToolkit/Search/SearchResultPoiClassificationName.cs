using System.Text.Json.Serialization;
namespace AzureMapsToolkit.Search
{
    public class SearchResultPoiClassificationName
    {
        /// <summary>
        /// Name property
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }


        /// <summary>
        /// Name Locale property
        /// </summary>
        [JsonPropertyName("nameLocale")]
        public string NameLocale { get; set; }
    }
}