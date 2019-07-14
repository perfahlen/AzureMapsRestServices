using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Spatial
{
    /// <summary>
    /// This object is returned from a successful Get Spatial Closest Point call
    /// </summary>
    public class ClosestPointResponse
    {
        /// <summary>
        /// Closest Point Result Array
        /// </summary>
        /// 
        [JsonProperty("result")]
        public ClosestPointResultEntry[] Result { get; set; }


        /// <summary>
        /// Get Closest Point Summary object
        /// </summary>
        [JsonProperty("summary")]
        public ClosestPointSummary Summary { get; set; }
    }
}
