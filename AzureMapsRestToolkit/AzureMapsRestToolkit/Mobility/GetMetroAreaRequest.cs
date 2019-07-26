using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Mobility
{
    public class GetMetroAreaRequest : RequestBase
    {
        /// <summary>
        /// The applicable location input. Can be position (specified as a comma separated string composed by latitude followed by longitude e.g. "47.641268,-122.125679") or countryCode (2-character ISO country code).
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Language in which search results will be returned. Only NGT is supported. Please refer to Supported languages for details.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// The type of the query. By default originType=position, specified as a comma separated string composed by latitude followed by longitude, e.g. "47.641268,-122.125679”.
        /// </summary>
        public QueryType QueryType { get; set; }
    }
}
