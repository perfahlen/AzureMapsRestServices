using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Mobility
{
    public class TransitLineInfoRequest : RequestBase
    {
        /// <summary>
        /// The unique id of the metro area. Required parameter specifying the required metro area to search in. Can be retrieved via Get Metro Area API.
        /// </summary>
        public int MetroId { get; set; }

        /// <summary>
        /// lineGroupId, for example,'666074'. Typically contains 2 lines having the same agency and line, one going from A to B, and the other from B to A.
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Specify additional details requested respective to the line group as a comma separated list. As a default service returns line basic info.
        /// </summary>
        public DetailType DetailType { get; set; }

        /// <summary>
        /// Language in which search results will be returned. Only NGT is supported. Please refer to Supported languages for details.
        /// </summary>
        public string Language { get; set; }
    }
}
