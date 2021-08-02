using AzureMapsToolkit.Common;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class GetForecastRequest : RequestBase
    {
        /// <summary>
        /// Coordinates of the location for which current conditions information is requested. The applicable query is specified as a comma separated string composed by latitude followed by longitude e.g. "47.641268,-122.125679".
        /// </summary>
        [JsonPropertyName("query")]
        public string Query { get; set; }

        /// <summary>
        /// Specifies for how many days the daily forecast responses are returned. Available values are
        /// 1 - Return forecast data for the next day. Returned by default.
        /// 5 - Return forecast data for the next 5 days.
        /// 10 - Return forecast data for the next 10 days.
        /// 25 - Return forecast data for the next 25 days.Only available in S1 SKU.
        /// 45 - Return forecast data for the next 45 days.Only available in S1 SKU.
        /// </summary>
        [JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Language in which search results should be returned. Should be one of supported IETF language tags, case insensitive. When data in specified language is not available for a specific field, default language is used. Default value is en-us.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Specifies to return the data in either metric units or imperial units. Default value is metric.
        /// </summary>
        [JsonPropertyName("unit")]
        public Unit Unit { get; set; }
    }
}
