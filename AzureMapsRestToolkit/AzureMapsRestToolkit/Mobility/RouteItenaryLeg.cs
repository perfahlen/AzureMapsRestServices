namespace AzureMapsToolkit.Mobility
{
    public class RouteItenaryLeg
    {
        /// <summary>
        /// For Public Transit legs the caption of the line serving the leg, for example, line number.
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// End time for the leg in ISO 8601 format, e.g. 1996-12-19T19:39:57-08:00.
        /// </summary>
        public string LegEndTime { get; set; }

        /// <summary>
        /// Start time for the leg in ISO 8601 format, e.g. 1996-12-19T19:39:57-08:00.
        /// </summary>
        public string LegStartTime { get; set; }

        /// <summary>
        /// The travel mode of the leg.
        /// </summary>
        public LegType LegType { get; set; }

        /// <summary>
        /// The total distance of the leg in meters.
        /// </summary>
        public uint LengthInMeters { get; set; }
    }
}