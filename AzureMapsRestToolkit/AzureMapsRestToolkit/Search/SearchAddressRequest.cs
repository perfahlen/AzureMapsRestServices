namespace AzureMapsToolkit.Search
{
    public class SearchAddressRequest : SearchRequestBase
    {
        /// <summary>
        /// Boolean. If the typeahead flag is set, the query will be interpreted as a partial input and the search will enter predictive modes
        /// </summary>
        public bool? Typeahead { get; set; }

        /// <summary>
        /// Maximum number of responses that will be returned. Default: 10, minimum: 1 and maximum: 100
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Starting offset of the returned results within the full result set.
        /// </summary>
        public int? Ofs { get; set; }

        /// <summary>
        /// Comma separated string of country codes, e.g. FR, ES. This will limit the search to the specified countries
        /// </summary>
        public string countrySet { get; set; }

        /// <summary>
        /// Latitude where results should be biased. E.g. 37.337
        /// </summary>
        public double? Lat { get; set; }

        /// <summary>
        /// Longitude where results should be biased.E.g. -121.89
        /// </summary>
        public double? Lon { get; set; }

        /// <summary>
        /// Top left position of the bounding box. E.g. 37.553,-122.453
        /// </summary>
        public string topLeft { get; set; }

        /// <summary>
        /// Bottom right position of the bounding box. E.g. 37.553,-122.453
        /// </summary>
        public string BtmRight { get; set; }

        /// <summary>
        /// Indexes for which extended postal codes should be included in the results.
        /// Available indexes are: 
        /// - Addr = Address ranges
        /// - Geo = Geographies
        /// - PAD = Point Addresses
        /// - POI = Points of Interest
        /// - Str = Streets
        ///  -XStr = Cross Streets(intersections)
        ///  Value should be a comma separated list of index types(in any order) or None for no indexes.
        ///  By default extended postal codes are included for all indexes except Geo. Extended postal code lists for geographies can be quite long so they have to be explicitly requested when needed.
        ///  Usage examples:
        ///  - extendedPostalCodesFor= POI
        ///   -extendedPostalCodesFor= PAD, Addr, POI
        ///   -extendedPostalCodesFor = None
        ///   Extended postal code is returned as an extendedPostalCode property of an address. Availability is region-dependent.
        /// </summary>
        public string ExtendedPostalCodesFor { get; set; }

        /// <summary>
        /// The radius in meters to for the results to be constrained to the defined area
        /// </summary>
        public double? Radius { get; set; }
    }
}
