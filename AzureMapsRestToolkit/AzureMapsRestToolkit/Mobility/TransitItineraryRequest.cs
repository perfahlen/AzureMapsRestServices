using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Mobility
{
    public class TransitItineraryRequest : RequestBase
    {
        /// <summary>
        /// The unique id (itineraryId) of an itinerary previously returned by Transit Route API.
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Specify additional details returned in the transit route itinerary response, as a comma separated list.
        /// </summary>
        public TransitItineraryDetailType DetailType { get; set; }

        /// <summary>
        /// Language in which search results will be returned. Only NGT is supported. Please refer to Supported languages for details.
        /// </summary>
        public string Language { get; set; }
    }
}
