using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Mobility
{
    public class TransitStopRequest: RequestBase
    {
        /// <summary>
        /// The unique id of the metro area. Required parameter specifying the required metro area to search in. Can be retrieved via Get Metro Area API.
        /// </summary>
        public int MetroId { get; set; }

        /// <summary>
        /// The stopId or stopKey for which the user is requesting transit stop details.
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// The type of the unique query parameter of the stop. By default queryType=stopId.
        /// </summary>
        public TransitStopQueryType QueryType { get; set; }

        /// <summary>
        /// Specify additional details requested respective to the transit stop as a commma separated list.
        /// </summary>
        public TransitStopDetailType DetailType { get; set; }

        /// <summary>
        /// Language in which search results will be returned. Only NGT is supported. Please refer to Supported languages for details.
        /// </summary>
        public string Language { get; set; }
    }
}
