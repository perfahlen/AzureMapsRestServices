using Newtonsoft.Json;
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
        [JsonProperty("information")]
        public string Information { get; set; }

        /// <summary>
        /// A location represented as a latitude and longitude
        /// </summary>
        [JsonProperty("sourcePoint")]
        public Coordinate SourcePoint { get; set; }


    }
}
