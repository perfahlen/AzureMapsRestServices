using System.Text.Json.Serialization;
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
        [JsonPropertyName("result")]
        public PointInPolygonResult Result { get; set; }

        /// <summary>
        /// Point In Polygon Summary object
        /// </summary>
        [JsonPropertyName("summary")]
        public GetPointInPolygonSummary Summary { get; set; }


    }
}
