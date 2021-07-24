using AzureMapsToolkit.Common;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class GetDailyIndicesRequest : RequestBase
    {
        /// <summary>
        /// Coordinates of the location for which daily indices are requested. The applicable query is specified as a comma separated string composed by latitude followed by longitude e.g. "47.641268,-122.125679".
        /// </summary>
        [JsonPropertyName("query")]
        public string Query { get; set; }

        /// <summary>
        /// Specifies for how many days the daily indices are returned. By default, the indices data for the current day will be returned. When requesting future indices data, the current day is included in the response as day 1. Available values are
        /// 1 - Return daily index data for the current day. Default value.
        /// 5 - Return 5 days of daily index data starting from the current day.
        /// 10 - Return 10 days of daily index data starting from the current day.
        /// 15 - Return 15 days of daily index data starting from the current day.
        /// </summary>
        [JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Numeric index group identifier that can be used for restricting returned results to the corresponding subset of indices (index group). Cannot be paired with indexId. Please refer to Weather Service Concepts for details and to see the supported index groups.
        /// </summary>
        [JsonPropertyName("indexGroupId")]
        public int? IndexGroupId { get; set; }

        /// <summary>
        /// Numeric index identifier that can be used for restricting returned results to the corresponding index type. Cannot be paired with indexGroupId. Please refer to Weather Service Concepts for details and to see the supported indices.
        /// </summary>
        [JsonPropertyName("indexId")]
        public int? IndexId { get; set; }

        /// <summary>
        /// Language in which search results should be returned. Should be one of supported IETF language tags, case insensitive. When data in specified language is not available for a specific field, default language is used. Default value is en-us.
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; }
    }
}
