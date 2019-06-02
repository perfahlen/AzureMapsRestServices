namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// A code identifying the maneuver.
    /// </summary>
    public enum GuidanceManeuver
    {
        /// <summary>
        /// You have arrived.
        /// </summary>
        ARRIVE,

        /// <summary>
        /// You have arrived. Your destination is on the left.
        /// </summary>
        ARRIVE_LEFT,

        /// <summary>
        /// You have arrived. Your destination is on the right.
        /// </summary>
        ARRIVE_RIGHT,

        /// <summary>
        /// Bear left.
        /// </summary>
        BEAR_LEFT,

        /// <summary>
        /// Bear right.
        /// </summary>
        BEAR_RIGHT,

        /// <summary>
        /// Leave
        /// </summary>
        DEPART,

        /// <summary>
        /// Take the freeway
        /// </summary>
        ENTER_FREEWAY,

        /// <summary>
        /// Take the highway.
        /// </summary>
        ENTER_HIGHWAY,

        /// <summary>
        /// Take the motorway
        /// </summary>
        ENTER_MOTORWAY,

        /// <summary>
        /// Take the ramp.
        /// </summary>
        ENTRANCE_RAMP,

        /// <summary>
        /// Follow
        /// </summary>
        FOLLOW,

        /// <summary>
        /// Keep left.
        /// </summary>
        KEEP_LEFT,

        /// <summary>
        /// Keep right.
        /// </summary>
        KEEP_RIGHT,

        /// <summary>
        /// Make a U-turn.
        /// </summary>
        MAKE_UTURN,

        /// <summary>
        /// Take the left exit.
        /// </summary>
        MOTORWAY_EXIT_LEFT,

        /// <summary>
        /// Take the right exit.
        /// </summary>
        MOTORWAY_EXIT_RIGHT,

        /// <summary>
        /// Go around the roundabout.
        /// </summary>
        ROUNDABOUT_BACK,

        /// <summary>
        /// Cross the roundabout.
        /// </summary>
        ROUNDABOUT_CROSS,

        /// <summary>
        /// At the roundabout take the exit on the left.
        /// </summary>
        ROUNDABOUT_LEFT,

        /// <summary>
        /// At the roundabout take the exit on the right.
        /// </summary>
        ROUNDABOUT_RIGHT,

        /// <summary>
        /// Turn sharp left.
        /// </summary>
        SHARP_LEFT,

        /// <summary>
        /// Turn sharp right.
        /// </summary>
        SHARP_RIGHT,

        /// <summary>
        /// Keep straight on
        /// </summary>
        STRAIGHT,

        /// <summary>
        /// Switch to the main road.
        /// </summary>
        SWITCH_MAIN_ROAD,

        /// <summary>
        /// Switch to the parallel road
        /// </summary>
        SWITCH_PARALLEL_ROAD,

        /// <summary>
        /// Take the exit.
        /// </summary>
        TAKE_EXIT,

        /// <summary>
        /// Take the ferry
        /// </summary>
        TAKE_FERRY,

        /// <summary>
        /// Try to make a U-turn
        /// </summary>
        TRY_MAKE_UTURN,

        /// <summary>
        /// Turn left.
        /// </summary>
        TURN_LEFT,

        /// <summary>
        /// Turn right.
        /// </summary>
        TURN_RIGHT,

        /// <summary>
        /// You have reached the waypoint. It is on the left.
        /// </summary>
        WAYPOINT_LEFT,

        /// <summary>
        /// You have reached the waypoint.
        /// </summary>
        WAYPOINT_REACHED,

        /// <summary>
        /// You have reached the waypoint. It is on the right.
        /// </summary>
        WAYPOINT_RIGHT,
    }
}
