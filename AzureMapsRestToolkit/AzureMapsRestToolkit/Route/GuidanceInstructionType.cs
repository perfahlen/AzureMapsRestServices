namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// Type of the instruction, e.g., turn or change of road form.
    /// </summary>
    public enum GuidanceInstructionType
    {
        /// <summary>
        /// Direction information.
        /// </summary>
        DIRECTION_INFO,

        /// <summary>
        /// Arrival location.
        /// </summary>
        LOCATION_ARRIVAL,

        /// <summary>
        /// Departure location.
        /// </summary>
        LOCATION_DEPARTURE,

        /// <summary>
        /// Way point location.
        /// </summary>
        LOCATION_WAYPOINT,

        /// <summary>
        /// Road Change.
        /// </summary>
        ROAD_CHANGE,

        /// <summary>
        /// Turn.
        /// </summary>
        TURN
    }
}
