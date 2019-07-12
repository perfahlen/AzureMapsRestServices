using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Spatial
{
    public class PointInPolygonResponse
    {
        /// <summary>
        /// Point In Polygon Result Object
        /// </summary>
        [JsonProperty("pointInPolygonResult")]
        public PointInPolygonResult Result { get; set; }

        /// <summary>
        /// Point In Polygon Summary object
        /// </summary>
        [JsonProperty("summary")]
        public GetPointInPolygonSummary Summary { get; set; }


    }
}
