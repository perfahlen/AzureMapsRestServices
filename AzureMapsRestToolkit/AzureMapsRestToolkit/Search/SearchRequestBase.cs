using AzureMapsToolkit.Common;
using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    public class SearchRequestBase : RequestBase
    {
        /// <summary>
        /// The address to search for (e.g., "1 Microsoft way, Redmond, WA"), must be properly URL encoded.
        /// </summary>
        public string Query { get; set; }

        
        /// <summary>
        /// Language in which search results should be returned. Should be one of supported IETF language tags, case insensitive. When data in specified language is not available for a specific field, default language is used.
        /// </summary>
        public string Language { get; set; }

        
    }
}
