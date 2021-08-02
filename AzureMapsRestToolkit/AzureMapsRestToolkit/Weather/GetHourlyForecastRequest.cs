using AzureMapsToolkit.Common;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class GetHourlyForecastRequest : RequestBase
    {
        /// <summary>
        /// Coordinates of the location for which hourly forecast information is requested. The applicable query is specified as a comma separated string composed by latitude followed by longitude e.g. "47.641268,-122.125679".
        /// </summary>
        [JsonPropertyName("query")]
        public string Query { get; set; }

        /// <summary>
        /// Time frame of the returned weather forecast. By default, the forecast data for next hour will be returned. Available values are
        /// 1 - Return forecast data for the next hour. Default value.
        /// 12 - Return hourly forecast for next 12 hours.
        /// 24 - Return hourly forecast for next 24 hours.
        /// 72 - Return hourly forecast for next 72 hours (3 days).
        /// 120 - Return hourly forecast for next 120 hours (5 days). Only available in S1 SKU.
        /// 240 - Return hourly forecast for next 240 hours (10 days). Only available in S1 SKU.
        /// </summary>
        [JsonPropertyName("duration")]
        public int? Duration { get; set; } = 1;

        /// <summary>
        /// Language in which search results should be returned. Should be one of supported IETF language tags, case insensitive. When data in specified language is not available for a specific field, default language is used. Default value is en-us.
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; }

        /// <summary>
        /// Specifies to return the data in either metric units or imperial units. Default value is metric.
        /// </summary>
        [JsonPropertyName("unit")]
        public Unit Unit { get; set; }


    }
}
