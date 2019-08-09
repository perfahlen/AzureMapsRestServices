using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Mobility
{
    public class TransitDockInfoRequest : RequestBase
    {
        /// <summary>
        /// dockId. Required parameter specifying the docking station to search for. Can be retrieved via Get Nearby Transit API.
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Language in which search results will be returned. Only NGT is supported. Please refer to Supported languages for details.
        /// </summary>
        public string Language { get; set; }
    }
}
