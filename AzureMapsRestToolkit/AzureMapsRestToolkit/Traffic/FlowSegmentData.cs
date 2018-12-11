using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Traffic
{
    /// <summary>
    /// Flow Segment Data property
    /// </summary>
    public class FlowSegmentData
    {
        /// <summary>
        /// @Version property
        /// </summary>
        [JsonProperty("@version")]
        public string Version { get; set; }

        /// <summary>
        /// Confidence property
        /// </summary>
        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        /// <summary>
        /// Coordinates of the result
        /// </summary>
        [JsonProperty("coordinates")]
        public Coordinates Coordinates { get; set; }

        /// <summary>
        /// Current Speed property
        /// </summary>
        [JsonProperty("currentSpeed")]
        public int CurrentSpped { get; set; }

        /// <summary>
        /// Current Travel Time property
        /// </summary>
        [JsonProperty("currentTravelTime")]
        public int currentTravelTime { get; set; }

        /// <summary>
        /// FRC property
        /// </summary>
        [JsonProperty("frc")]
        public string FRC { get; set; }

        /// <summary>
        /// Free Flow Speed property
        /// </summary>
        [JsonProperty("freeFlowSpeed")]
        public int FreeFlowSpeed { get; set; }

        /// <summary>
        /// Free Flow Travel Time property
        /// </summary>
        [JsonProperty("freeFlowTravelTime")]
        public int FreeFlowTravelTime { get; set; }
    }
}
