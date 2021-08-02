using AzureMapsToolkit.Common;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class GetWeatherAlongRouteRequest : RequestBase
    {
        /// <summary>
        /// Coordinates through which the route is calculated, separated by colon (:) and entered in chronological order. A minimum of two waypoints is required. A single API call may contain up to 60 waypoints. A waypoint indicates location, ETA, and optional heading: latitude,longitude,ETA,heading, where
        /// Latitude - Latitude coordinate in decimal degrees.
        /// Longitude - Longitude coordinate in decimal degrees.
        /// ETA(estimated time of arrival) - The number of minutes from the present time that it will take for the vehicle to reach the waypoint.Allowed range is from 0.0 to 120.0 minutes.
        /// Heading - An optional value indicating the vehicle heading as it passes the waypoint. Expressed in clockwise degrees relative to true north.This is issued to calculate sun glare as a driving hazard.Allowed range is from 0.0 to 360.0 degrees.If not provided, a heading will automatically be derived based on the position of neighboring waypoints.
        /// It is recommended to stay within, or close to, the distance that can be traveled within 120-mins or shortly after. This way a more accurate assessment can be provided for the trip and prevent isolated events not being captured between waypoints. Information can and should be updated along the route (especially for trips greater than 2 hours) to continuously pull new waypoints moving forward, but also to ensure that forecast information for content such as precipitation type and intensity is accurate as storms develop and dissipate over time.
        /// </summary>
        [JsonPropertyName("query")]
        public string Query { get; set; }

        /// <summary>
        /// Language in which search results should be returned. Should be one of supported IETF language tags, case insensitive. When data in specified language is not available for a specific field, default language is used. Default value is en-us.
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; }
    }
}
