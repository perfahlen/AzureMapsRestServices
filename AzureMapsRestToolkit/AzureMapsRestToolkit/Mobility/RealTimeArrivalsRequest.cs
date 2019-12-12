using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Mobility
{
    public class RealTimeArrivalsRequest: RequestBase
    {
        /// <summary>
        /// The unique id of the metro area. Required parameter specifying the required metro area to search in. Can be retrieved via Get Metro Area API.
        /// </summary>
        public int MetroId { get; set; }

        /// <summary>
        /// Stop, line or location identifier.
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// The type of the query parameter. Defines the mode of the request. Only one mode per request is supported. By default queryType is set to be ‘stops’ returning the requested number of Live Arrivals for all lines arriving at the specified stop.
        /// </summary>
        public RealTimeQueryType QueryType { get; set; } = RealTimeQueryType.Stops;

        /// <summary>
        /// The type of the unique query parameter of the stop. By default stopQueryType=stopId. This parameter can only be used in conjunction with queryType=stops or queryType=lineAndStop.
        /// </summary>
        public StopQueryType? StopQueryType { get; set; }

        /// <summary>
        /// The maximum arrivals to return. If not specified, the system default will be used. For stops max number of arrivals per stop. For lines max arrivals per stop on the line. For everything else max arrivals overall.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// The maximum time (in minutes) in the future to return arrivals for. If not specified, the system default (30 minutes) will be used. The minimum value is 0 and maximum value is 60 minutes.
        /// </summary>
        public int MaxMinutesInFuture { get; set; } = 30;

        /// <summary>
        /// Type of public transit user is requesting respective transit stop, as a comma separated list. If not specified, all will be allowed. This parameter can only be used in conjunction with queryType=stops. Supported transit types are Tram, Subway, Rail, Bus, Ferry, CableCar, Gondola, Funicular. For example, transitType=Bus,Subway.
        /// </summary>
        public TransitTypeFilter TransitType { get; set; }

        /// <summary>
        /// In case you prefer routes from a specific set of agencies to be returned. Specified as a comma separated string.
        /// </summary>
        public string Agency { get; set; }

        /// <summary>
        /// Specifies the agency identifier to request routes from a specific set of agencies to be returned. By default the agencyType=agencyId.
        /// </summary>
        public AgencyType AgencyType { get; set; } = AgencyType.AgencyId;

        /// <summary>
        /// Time in seconds within which if the provider doesn’t respond, end point will return static data.
        /// </summary>
        public int? TimeoutInSeconds { get; set; }

        /// <summary>
        /// Language in which search results will be returned. Only NGT is supported. Please refer to Supported languages for details.
        /// </summary>
        public string Language { get; set; }


    }
}
