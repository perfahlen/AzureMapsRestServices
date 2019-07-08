using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Spatial
{
    public class Coordinate
    {
        /// <summary>
        /// Latitude property
        /// </summary>
        [JsonProperty("lat")]
        public double Lat { get; set; }

        /// <summary>
        /// Longitude property
        /// </summary>
        [JsonProperty("lon")]
        public double Lon { get; set; }
    }
}
