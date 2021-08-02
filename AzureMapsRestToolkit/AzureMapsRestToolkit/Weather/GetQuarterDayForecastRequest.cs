using AzureMapsToolkit.Common;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class GetQuarterDayForecastRequest : RequestBase
    {
        /// <summary>
        /// Coordinates of the location for which quarter-day forecast information is requested. The applicable query is specified as a comma separated string composed by latitude followed by longitude e.g. "47.641268,-122.125679".
        /// </summary>
        [JsonPropertyName("query")]
        public string Query { get; set; }

        public int MyProperty { get; set; }
    }
}
