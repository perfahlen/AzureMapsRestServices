using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Search
{
    public class SearchPoiCategoryRequest : SearchPoiRequest
    {
        /// <summary>
        /// Multiplies the limit by this value to gather more candidate POIs, which will then be sorted by drive distance, returning only the top candidates according to the limit.
        /// </summary>
        public int? Multiplier { get; set; }

        /// <summary>
        /// Number of milliseconds routing engine can take to give the results.
        /// </summary>
        public int? RoutingTimeout { get; set; }

        /// <summary>
        /// Top left position of the bounding box. E.g. 37.553,-122.453
        /// </summary>
        public string   TopLeft  { get; set; }

        /// <summary>
        /// Bottom right position of the bounding box. E.g. 37.553,-122.453
        /// </summary>
        public string BtmRight { get; set; }

    }
}
