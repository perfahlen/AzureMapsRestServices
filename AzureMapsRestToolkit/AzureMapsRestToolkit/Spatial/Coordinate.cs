using System.Text.Json.Serialization;
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
        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        /// <summary>
        /// Longitude property
        /// </summary>
        [JsonPropertyName("lon")]
        public double Lon { get; set; }
    }
}
