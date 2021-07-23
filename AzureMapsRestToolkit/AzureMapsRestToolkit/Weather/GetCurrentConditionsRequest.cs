using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Weather
{
    /// <summary>
    /// Get Current Conditions service returns detailed current weather conditions such as precipitation, temperature and wind for a given coordinate location. Also, observations from the past 6 or 24 hours for a particular location can be retrieved. The basic information returned with the response include details such as observation date and time, brief description of the weather conditions, weather icon, precipitation indicator flags, and temperature. Additional details such as RealFeel™ Temperature and UV index are also returned.
    /// </summary>
    public class GetCurrentConditionsRequest : RequestBase
    {
        /// <summary>
        /// Coordinates of the location for which current conditions information is requested. The applicable query is specified as a comma separated string composed by latitude followed by longitude e.g. "47.641268,-122.125679".
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Return full details for the current conditions. Available values are
        /// - true - Returns full details.By default all details are returned.
        /// - false - Returns a truncated version of the current condition data, which includes observation date time, weather phrase, icon code, precipitation indicator flag, and temperature.
        /// </summary>
        public bool Details { get; set; } = true;

        /// <summary>
        /// Time frame of the returned weather conditions. By default, the most current weather conditions will be returned. Default value is 0. Supported values are:
        /// -0 - Return the most current weather conditions.
        /// 6 - Return weather conditions from past 6 hours.
        /// 24 - Return weather conditions from past 24 hours.
        /// </summary>
        public int Duration { get; set; } = 0;

        /// <summary>
        /// Language in which search results should be returned. Should be one of supported IETF language tags, case insensitive. When data in specified language is not available for a specific field, default language is used. Default value is en-us.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Specifies to return the data in either metric units or imperial units. Default value is metric.
        ///  - imperial
        ///  - metric
        /// </summary>
        public string Unit { get; set; }
    }
    
}
