using System.Text.Json.Serialization;
namespace AzureMapsToolkit.Search
{
    public class SearchResultPoiClassification
    { 

        /// <summary>
        /// Code property
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }


        /// <summary>
        /// Names array
        /// </summary>
        [JsonPropertyName("names")]
        public SearchResultPoiClassificationName[] Names { get; set; }

    }
}
