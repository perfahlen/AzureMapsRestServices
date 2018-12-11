namespace AzureMapsToolkit.Search
{
    public class SearchInsidePolygonRequest : SearchRequestBaseExtended
    {
        /**
         * hack to hide
         * */
        public new int? Offset { get; set; }


        /// <summary>
        /// A comma separated list of indexes which should be utilized for the search. Item order does not matter. Available indexes are: Addr = Address range interpolation, Geo = Geographies, PAD = Point Addresses, POI = Points of interest, Str = Streets, Xstr = Cross Streets (intersections)
        /// </summary>
        public string[] IdxSet { get; set; }
    }
}
