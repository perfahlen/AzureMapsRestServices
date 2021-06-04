using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Traffic
{
    /// <summary>
    /// This object is returned from a successful Traffic Flow Segment call
    /// </summary>
    public class TrafficFlowSegmentResult
    {
        /// <summary>
        /// Flow Segment Data property
        /// </summary>
        [JsonPropertyName("flowSegmentData")]
        public FlowSegmentData FlowSegmentData { get; set; }
    }
}
