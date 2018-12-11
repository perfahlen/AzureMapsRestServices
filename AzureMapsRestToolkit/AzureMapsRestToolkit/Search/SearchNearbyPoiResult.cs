using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    public class SearchNearbyPoiResult : SearchResult
    {

        
        /// <summary>
        /// Straight line distance between the result and geobias location in meters.
        /// </summary>
        [JsonProperty("dist")]
        public double Distance { get; set; }

        /// <summary>
        /// Info property
        /// </summary>
        [JsonProperty("info")]
        public string Info { get; set; }


    }
}