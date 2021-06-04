using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Spatial
{
    public class PostPointInPolygonSummary
    {
        /// <summary>
        /// Processing information
        /// </summary>
        [JsonPropertyName("information")]
        public string Information { get; set; }

        /// <summary>
        /// A location represented as a latitude and longitude
        /// </summary>
        [JsonPropertyName("sourcePoint")]
        public Coordinate SourcePoint { get; set; }


    }
}
