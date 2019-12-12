using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Mobility
{
    public class NearbyTransitRequest : RequestBase
    {

        /// <summary>
        /// The unique id of the metro area. Required parameter specifying the required metro area to search in. Can be retrieved via Get Metro Area API.
        /// </summary>
        public int MetroId { get; set; }

        /// <summary>
        /// Location input from user. The applicable location query specified as a comma separated string composed by latitude followed by longitude e.g. "47.641268,-122.125679".
        /// </summary>
        public string Query { get; set; }


        /// <summary>
        /// Maximum number of responses that will be returned. Default is 3, minimum 1 and maximum 100. Sort order is based on distance from input location.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Specifies the search area to constrain a search. The radius in meters to for the results to be constrained to the defined area. Default value is 30 meters, minimum 1 meter and maximum 5000 meters (5km).
        /// </summary>
        public int? Radius { get; set; }

        /// <summary>
        /// Comma separated list of transit object types. By default, objectType is set to stop. Use constants in ObjectType
        /// </summary>
        public string ObjectType { get; set; }

        /// <summary>
        /// Language in which search results will be returned. Only NGT is supported. Please refer to Supported languages for details.
        /// </summary>
        public string Language { get; set; }

    }
}
