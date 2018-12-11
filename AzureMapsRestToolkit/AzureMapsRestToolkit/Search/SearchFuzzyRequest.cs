using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    public class SearchFuzzyRequest: SearchRequestBaseExtended
    {

        
        /// <summary>
        /// Maximum fuzzyness level to be used. Default: 2, minimum: 1 and maximum: 4
        /// - Level 1 has no spell checking.
        /// - Level 2 uses normal n-gram spell checking. For example, query "restrant" can be matched to "restaurant."
        /// - Level 3 uses sound-like spell checking, and shingle spell checking. Sound-like spell checking is for "rstrnt" to "restaurant" matching. Shingle spell checking is for "mountainview" to "mountain view" matching
        /// - Level 4 doesn’t add any more spell checking functions.
        /// 
        /// The search engine will start looking for a match on the level defined by minFuzzyLevel, and will stop searching at the level specified by maxFuzzyLevel. 
        /// </summary>
        public int? MinFuzzyLevel { get; set; }


        /// <summary>
        /// Bottom right position of the bounding box. E.g. 37.553,-122.453
        /// </summary>
        public string BtmRight { get; set; }

        /// <summary>
        /// Top left position of the bounding box. E.g. 37.553,-122.453
        /// </summary>
        public string TopLeft { get; set; }

        /// <summary>
        /// The radius in meters to for the results to be constrained to the defined area
        /// </summary>
        public double? Radius { get; set; }

        /// <summary>
        /// Longitude where results should be biased. E.g. -121.89
        /// </summary>
        public double? Lon { get; set; }

        /// <summary>
        /// Latitude where results should be biased. E.g. 37.337
        /// </summary>
        public double? Lat { get; set; }

        /// <summary>
        /// Comma separated string of country codes, e.g. FR, ES. This will limit the search to the specified countries
        /// </summary>
        public string[] CountrySet { get; set; }

        /// <summary>
        /// Boolean. If the typeahead flag is set, the query will be interpreted as a partial input and the search will enter predictive mode
        /// </summary>
        public bool? Typeahead { get; set; } 

        /// <summary>
        /// Maximum fuzzyness level to be used. Default: 2, minimum: 1 and maximum: 4
        /// - Level 1 has no spell checking.
        /// - Level 2 uses normal n-gram spell checking. For example, query "restrant" can be matched to "restaurant."
        /// - Level 3 uses sound-like spell checking, and shingle spell checking. Sound-like spell checking is for "rstrnt" to "restaurant" matching. Shingle spell checking is for "mountainview" to "mountain view" matching
        /// - Level 4 doesn’t add any more spell checking functions.
        /// 
        /// The search engine will start looking for a match on the level defined by minFuzzyLevel, and will stop searching at the level specified by maxFuzzyLevel. 
        /// </summary>
        public int? MaxFuzzyLevel { get; set; }

        /// <summary>
        /// A comma separated list of indexes which should be utilized for the search. Item order does not matter. Available indexes are: Addr = Address range interpolation, Geo = Geographies, PAD = Point Addresses, POI = Points of interest, Str = Streets, Xstr = Cross Streets (intersections)
        /// </summary>
        public string[] IdxSet { get; set; }
    }
}
