using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Search
{
    public class SearchNearbyPoiResult : SearchResult
    {

        
        /// <summary>
        /// Straight line distance between the result and geobias location in meters.
        /// </summary>
        [JsonPropertyName("dist")]
        public double Distance { get; set; }

        /// <summary>
        /// Info property
        /// </summary>
        [JsonPropertyName("info")]
        public string Info { get; set; }


    }
}