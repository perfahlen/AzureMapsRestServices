using Newtonsoft.Json;

namespace AzureMapsToolkit.Mobility
{
    /// <summary>
    /// Contains real-time arrival related details.
    /// </summary>
    public class RealTimeArrivalResult
    {
        /// <summary>
        /// The estimated time of arrival in minutes.
        /// </summary>
        [JsonProperty("arrivalMinutes")]
        public int ArrivalMinutes { get; set; }

        /// <summary>
        /// The public transit type of the line.
        /// </summary>
        [JsonProperty("line")]
        public Line Line { get; set; }

        /// <summary>
        /// The pattern Id.
        /// </summary>
        public string PatternId { get; set; }

        /// <summary>
        /// Whether the result is based on real-time or static data.
        /// </summary>
        public ScheduleType ScheduleType { get; set; }

        /// <summary>
        /// Object for the given stop.
        /// </summary>
        public Stop Stop { get; set; }
    }
}