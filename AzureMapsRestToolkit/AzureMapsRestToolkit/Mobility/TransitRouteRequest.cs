using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Mobility
{
    public class TransitRouteRequest : RequestBase
    {
        /// <summary>
        /// The type of route requested. If not specified, 'optimal' will be used.
        /// </summary>
        public RouteType RouteType { get; set; }

        /// <summary>
        /// Specifies whether the time signifies departure time or arrival time. If not defined, default value is 'departure'.
        /// </summary>
        public TimeType TimeType { get; set; }

        /// <summary>
        /// The time of departure or arrival in the local time in ISO format (2019-04-05T14:24:18-04:00). If timeType is not specified, it will be assumed to be 'departure' and time is the current local time at the origin point.
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// Specifies the agency identifier to request routes from preferred agencies. By default the agencyType=agencyId.
        /// </summary>
        public AgencyType AgencyType { get; set; }

        /// <summary>
        /// Specifies whether to prefer routes from a specific set of agencies if possible; as a comma separated list. If valid trip isn’t found with the preferred agency, or only one with very long trips or with large number of transfers, itineraries with other agencies will be returned.
        /// </summary>
        public string Agency { get; set; }

        /// <summary>
        /// Applicable only with modeType = publicTransit. Allow only a specific set of public transit types (as a comma separated list) to be returned for the route. Note that the requested transitType may not be available for the entire route. If not specified, all modes will be allowed.
        /// </summary>
        public TransitTypeFilter TransitType { get; set; }

        /// <summary>
        /// Bike type of the bike. Specifies which type of bikes will be used. If not specified, all will be allowed.
        /// </summary>
        public BikeType BikeType { get; set; }

        /// <summary>
        /// The mode of travel for the requested route; as comma separated list. If not specified, all modes will be allowed. All modes might not be available in all metro areas. If valid trip is not found, empty result will be returned.
        /// </summary>
        public ModeType ModeType { get; set; }

        /// <summary>
        /// The destination of the route. By default the destinationType=position, specified as a comma separated string composed by latitude followed by longitude, e.g. "47.641268,-122.125679”.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// The type of the origin. By default originType=position, specified as a comma separated string composed by latitude followed by longitude, e.g., "47.641268,-122.125679”.
        /// </summary>
        public OriginType OriginType { get; set; }

        /// <summary>
        /// The origin of the route. By default originType=position, specified as a comma separated string composed by latitude followed by longitude, e.g. "47.641268,-122.125679”.
        /// </summary>
        public string Origin { get; set; }

        /// <summary>
        /// The unique id of the metro area. Required parameter specifying the required metro area to search in. Can be retrieved via Get Metro Area API.
        /// </summary>
        public int MetroId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DestinationType? DestinationType { get; set; }

        /// <summary>
        /// Language in which search results will be returned. Only NGT is supported. Please refer to Supported languages for details.
        /// </summary>
        public string Language { get; set; }
    }
}
