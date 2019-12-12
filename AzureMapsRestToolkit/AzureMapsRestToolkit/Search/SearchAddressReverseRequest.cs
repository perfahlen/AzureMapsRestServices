using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    public class SearchAddressReverseRequest : SearchRequestBase
    {

        public bool? ReturnSpeedLimit { get; set; }

        /// <summary>
        /// The directional heading of the vehicle in degrees, for travel along a segment of roadway. 0 is North, 90 is East and so on, values range from -360 to 360. The precision can include upto one decimal place
        /// </summary>
        public double? Heading { get; set; }

        /// <summary>
        /// If a number is sent in along with the request, the response may include the side of the street (Left/Right) and also an offset position for that number
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Boolean. To enable return of the road use array for reversegeocodes at street level
        /// </summary>
        public bool? ReturnRoadUse { get; set; }

        /// <summary>
        /// To restrict reversegeocodes to a certain type of roaduse.The road use array for reversegeocodes can be one or more of LimitedAccess, Arterial, Terminal, Ramp, Rotary, LocalStreet
        /// </summary>
        public string RoadUse { get; set; }

        /// <summary>
        /// Format of newlines in the formatted address.
        /// If true, the address will contain newlines. If false, newlines will be converted to commas.
        /// </summary>
        public bool? AllowFreeformNewline { get; set; }


        /// <summary>
        /// The date and time to return time zone information for. It allows the service to decide whether Daylight Saving Time time zone should be used or not. It must conform to RFC-3339.
        /// Examples:
        /// - 2017-12-19T16:39:57
        /// - 2017-12-19T16:39:57-08:00
        /// </summary>
        public string DateTime { get; set; }

        /// <summary>
        /// Include information on the type of match the geocoder achieved in the response.
        /// </summary>
        public bool? ReturnMatchType { get; set; }

        /// <summary>
        /// The radius in meters to for the results to be constrained to the defined area
        /// </summary>
        public double? Radius { get; set; }

        /// <summary>
        /// Limit property
        /// </summary>
        public int? Limit { get; set; }


    }
}
