using AzureMapsToolkit.Common;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class GetSevereWeatherAlertsRequest : RequestBase
    {
        /// <summary>
        /// Coordinates of the location for which severe weather alerts are requested. The applicable query is specified as a comma separated string composed by latitude followed by longitude e.g. "47.641268,-122.125679".
        /// </summary>
        [JsonPropertyName("query")]
        public string Query { get; set; }

        /// <summary>
        /// Return full details for the severe weather alerts. Available values are. true - Returns full details. By default all details are returned. false - Returns a truncated version of the alerts data, which excludes the area-specific full description of alert details (alertDetails).
        /// </summary>
        [JsonPropertyName("details")]
        public string Details { get; set; }

        /// <summary>
        /// Language in which search results should be returned. Should be one of supported IETF language tags, case insensitive. When data in specified language is not available for a specific field, default language is used. Default value is en-us.
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; }



    }
}
