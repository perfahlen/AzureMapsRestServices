using AzureMapsToolkit.Common;
using System.Collections.Generic;

namespace AzureMapsToolkit.Mobility
{
    public class GetMetroAreaInfoRequest : RequestBase
    {
        /// <summary>
        /// metroId. The unique id of the metro area. Required parameter specifying the required metro area to search in. Can be retrieved via Get Metro Area API.
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Specify additional details requested respective to the metro area as a commma separated list. Use Constants in DetailType.
        /// </summary>
        public string DetailType { get; set; }

        //public DetailType DetailType { get; set; }

        /// <summary>
        /// Language in which search results will be returned. Only NGT is supported. Please refer to Supported languages for details.
        /// </summary>
        public string Language { get; set; }
    }
}
