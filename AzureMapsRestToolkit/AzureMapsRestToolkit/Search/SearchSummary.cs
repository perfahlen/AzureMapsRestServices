using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    public class SearchSummary
    {
        /// <summary>
        /// FuzzyLevel property
        /// </summary>
        [JsonProperty("fuzzyLevel")]
        public int FuzzyLevel { get; set; }

        /// <summary>
        /// NumResults property
        /// </summary>
        [JsonProperty("numResults")]
        public int NumResults { get; set; }

        /// <summary>
        /// Offset property
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// Query property
        /// </summary>
        [JsonProperty("query")]
        public string Query { get; set; }

        /// <summary>
        /// QueryTime property
        /// </summary>
        [JsonProperty("queryTime")]
        public int QueryTime { get; set; }

        /// <summary>
        /// QueryType property
        /// </summary>
        [JsonProperty("queryType")]
        public string QueryType { get; set; }

        /// <summary>
        /// TotalResults property
        /// </summary>
        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }
    }
}
