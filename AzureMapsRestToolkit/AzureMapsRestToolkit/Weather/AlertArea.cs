using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class AlertArea
    {
        /// <summary>
        /// Full details associated with the alert. Returned if details=True. This field is always returned in the language(s) of choice by the issuing provider and Azure Maps only returns what is created by the provider. Please note, some countries/regions may offer their native language and English. Language parameter won’t apply to this field.
        /// </summary>
        [JsonPropertyName("alertDetails")]
        public string AlertDetails { get; set; }

        /// <summary>
        /// Language of the alertDetails. This field helps to point out that the language of the alertDetails may differ from the requested language parameter. Returned if details=True. Language code has been derived from the ISO 639-1 Alpha-2 codes.
        /// </summary>
        [JsonPropertyName("alertDetailsLanguageCode")]
        public string AlertDetailsLanguageCode { get; set; }

        /// <summary>
        /// The end date and time of the alert in ISO 8601 format, for example, 2019-10-27T19:39:57-08:00. If the alert crosses multiple time zones the returned time in the response is the local time to the requested coordinate location.
        /// </summary>
        [JsonPropertyName("endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// The latest status of the alert in the current area.
        /// </summary>
        [JsonPropertyName("latestStatus")]
        public LatestStatus LatestStatus { get; set; }

        /// <summary>
        /// The name of an area which is affected by the alert. The location that was requested falls under the alert area.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The start date and time of the alert in ISO 8601 format, for example, 2019-10-27T19:39:57-08:00. If the alert crosses multiple time zones the returned time in the response is the local time to the requested coordinate location.
        /// </summary>
        [JsonPropertyName("startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// Text summarizing the alert in the returned area.
        /// </summary>
        [JsonPropertyName("summary")]
        public string Summary { get; set; }


    }
}