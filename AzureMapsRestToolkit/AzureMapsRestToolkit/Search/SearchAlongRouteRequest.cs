using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Search
{
    public class SearchAlongRouteRequest : RequestBase
    {
        /// <summary>
        /// The applicable query string (e.g., "burger joints", "pizza"). Can also be specified as a comma separated string composed by latitude followed by longitude (e.g., "47.641268, -122.125679"). Must be properly URL encoded.
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Maximum detour time of the point of interest in seconds. Max value is 3600 seconds
        /// </summary>
        public int? MaxDetourTime { get; set; }

        /// <summary>
        /// Maximum number of responses that will be returned. Default value is 10. Max value is 20
        /// </summary>
        public int? Limit { get; set; }
    }
}
