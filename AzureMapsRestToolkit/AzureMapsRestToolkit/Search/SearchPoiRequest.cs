namespace AzureMapsToolkit.Search
{
    public class SearchPoiRequest : SearchNearbyRequest
    {
        /// <summary>
        /// The POI name to search for (e.g., "statue of liberty", "starbucks"), must be properly URL encoded.
        /// </summary>
        public new string Query { get; set; }

        /// <summary>
        /// Boolean. If the typeahead flag is set, the query will be interpreted as a partial input and the search will enter predictive mode
        /// </summary>
        public bool Typeahead { get; set; }
    }
}
