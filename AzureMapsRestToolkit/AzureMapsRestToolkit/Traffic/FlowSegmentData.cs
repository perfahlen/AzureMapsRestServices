using System.Text.Json.Serialization;
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
        [JsonPropertyName("@version")]
        public string Version { get; set; }

        /// <summary>
        /// Confidence property
        /// </summary>
        [JsonPropertyName("confidence")]
        public double Confidence { get; set; }

        /// <summary>
        /// Coordinates of the result
        /// </summary>
        [JsonPropertyName("coordinates")]
        public Coordinates Coordinates { get; set; }

        /// <summary>
        /// Current Speed property
        /// </summary>
        [JsonPropertyName("currentSpeed")]
        public int CurrentSpped { get; set; }

        /// <summary>
        /// Current Travel Time property
        /// </summary>
        [JsonPropertyName("currentTravelTime")]
        public int currentTravelTime { get; set; }

        /// <summary>
        /// FRC property
        /// </summary>
        [JsonPropertyName("frc")]
        public string FRC { get; set; }

        /// <summary>
        /// Free Flow Speed property
        /// </summary>
        [JsonPropertyName("freeFlowSpeed")]
        public int FreeFlowSpeed { get; set; }

        /// <summary>
        /// Free Flow Travel Time property
        /// </summary>
        [JsonPropertyName("freeFlowTravelTime")]
        public int FreeFlowTravelTime { get; set; }
    }
}
