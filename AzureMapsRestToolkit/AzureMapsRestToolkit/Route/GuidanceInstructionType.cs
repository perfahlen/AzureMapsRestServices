namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// Type of the instruction, e.g., turn or change of road form.
    /// </summary>
    public class GuidanceInstructionType
    {
        /// <summary>
        /// Direction information.
        /// </summary>
        public string DIRECTION_INFO { get; set; }

        /// <summary>
        /// Arrival location.
        /// </summary>
        public string LOCATION_ARRIVAL { get; set; }

        /// <summary>
        /// Departure location.
        /// </summary>
        public string LOCATION_DEPARTURE { get; set; }

        /// <summary>
        /// Way point location.
        /// </summary>
        public string LOCATION_WAYPOINT { get; set; }

        /// <summary>
        /// Road Change.
        /// </summary>
        public string ROAD_CHANGE { get; set; }

        /// <summary>
        /// Turn.
        /// </summary>
        public string TURN { get; set; }
    }
}
