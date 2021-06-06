using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Search
{
    public class SearchSummary
    {
        /// <summary>
        /// FuzzyLevel property
        /// </summary>
        [JsonPropertyName("fuzzyLevel")]
        public int FuzzyLevel { get; set; }

        /// <summary>
        /// NumResults property
        /// </summary>
        [JsonPropertyName("numResults")]
        public int NumResults { get; set; }

        /// <summary>
        /// Offset property
        /// </summary>
        [JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// Query property
        /// </summary>
        [JsonPropertyName("query")]
        public string Query { get; set; }

        /// <summary>
        /// QueryTime property
        /// </summary>
        [JsonPropertyName("queryTime")]
        public int QueryTime { get; set; }

        /// <summary>
        /// QueryType property
        /// </summary>
        [JsonPropertyName("queryType")]
        public string QueryType { get; set; }

        /// <summary>
        /// TotalResults property
        /// </summary>
        [JsonPropertyName("totalResults")]
        public int TotalResults { get; set; }
    }
}
