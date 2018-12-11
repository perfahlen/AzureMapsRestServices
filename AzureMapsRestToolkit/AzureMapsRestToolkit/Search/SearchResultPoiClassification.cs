using Newtonsoft.Json;
namespace AzureMapsToolkit.Search
{
    public class SearchResultPoiClassification
    { 

        /// <summary>
        /// Code property
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }


        /// <summary>
        /// Names array
        /// </summary>
        [JsonProperty("names")]
        public SearchResultPoiClassificationName[] Names { get; set; }

    }
}
