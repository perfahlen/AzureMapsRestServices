namespace AzureMapsToolkit.Mobility
{
    public class LineArrival
    {
        /// <summary>
        /// Line Id
        /// </summary>
        public string LineId { get; set; }

        /// <summary>
        /// The date and time of departure from the stop in ISO 8601 format, e.g. 1996-12-19T19:39:57-08:00.
        /// </summary>
        public string ScheduleTime { get; set; }

        /// <summary>
        /// Whether the result is based on real-time or static data.
        /// </summary>
        public ScheduleType ScheduleType { get; set; }

        /// <summary>
        /// The unique Azure Maps identifier for the respective public transit stop. When referring stops overtime, it is suggested to use stopId that will not change if the physical stop exists.
        /// </summary>
        public string StopId { get; set; }
    }
}