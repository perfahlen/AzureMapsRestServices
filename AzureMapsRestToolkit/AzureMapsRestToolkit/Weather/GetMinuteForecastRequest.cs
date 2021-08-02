using AzureMapsToolkit.Common;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class GetMinuteForecastRequest : RequestBase
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("query")]
        public string Query { get; set; }

        /// <summary>
        /// Specifies time interval in minutes for the returned weather forecast. Supported values are: 1 - Retrieve forecast for 1-minute intervals. Returned by default. 5 - Retrieve forecasts for 5-minute intervals.15 - Retrieve forecasts for 15-minute intervals.
        /// </summary>
        [JsonPropertyName("interval")]
        public int? Interval { get; set; }

        /// <summary>
        /// Language in which search results should be returned. Should be one of supported IETF language tags, case insensitive. When data in specified language is not available for a specific field, default language is used. Default value is en-us.
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; }


    }
}
