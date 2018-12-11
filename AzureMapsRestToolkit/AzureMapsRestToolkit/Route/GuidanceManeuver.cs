namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// A code identifying the maneuver.
    /// </summary>
    public class GuidanceManeuver
    {
        /// <summary>
        /// You have arrived.
        /// </summary>
        public string ARRIVE { get; set; }

        /// <summary>
        /// You have arrived. Your destination is on the left.
        /// </summary>
        public string ARRIVE_LEFT { get; set; }

        /// <summary>
        /// You have arrived. Your destination is on the right.
        /// </summary>
        public string ARRIVE_RIGHT { get; set; }

        /// <summary>
        /// Bear left.
        /// </summary>
        public string BEAR_LEFT { get; set; }

        /// <summary>
        /// Bear right.
        /// </summary>
        public string BEAR_RIGHT { get; set; }

        /// <summary>
        /// Leave
        /// </summary>
        public string DEPART { get; set; }

        /// <summary>
        /// Take the freeway
        /// </summary>
        public string ENTER_FREEWAY { get; set; }

        /// <summary>
        /// Take the highway.
        /// </summary>
        public string ENTER_HIGHWAY { get; set; }

        /// <summary>
        /// Take the motorway
        /// </summary>
        public string ENTER_MOTORWAY { get; set; }

        /// <summary>
        /// Take the ramp.
        /// </summary>
        public string ENTRANCE_RAMP { get; set; }

        /// <summary>
        /// Follow
        /// </summary>
        public string FOLLOW { get; set; }

        /// <summary>
        /// Keep left.
        /// </summary>
        public string KEEP_LEFT { get; set; }

        /// <summary>
        /// Keep right.
        /// </summary>
        public string KEEP_RIGHT { get; set; }

        /// <summary>
        /// Make a U-turn.
        /// </summary>
        public string MAKE_UTURN { get; set; }

        /// <summary>
        /// Take the left exit.
        /// </summary>
        public string MOTORWAY_EXIT_LEFT { get; set; }

        /// <summary>
        /// Take the right exit.
        /// </summary>
        public string MOTORWAY_EXIT_RIGHT { get; set; }

        /// <summary>
        /// Go around the roundabout.
        /// </summary>
        public string ROUNDABOUT_BACK { get; set; }

        /// <summary>
        /// Cross the roundabout.
        /// </summary>
        public string ROUNDABOUT_CROSS { get; set; }

        /// <summary>
        /// At the roundabout take the exit on the left.
        /// </summary>
        public string ROUNDABOUT_LEFT { get; set; }

        /// <summary>
        /// At the roundabout take the exit on the right.
        /// </summary>
        public string ROUNDABOUT_RIGHT { get; set; }

        /// <summary>
        /// Turn sharp left.
        /// </summary>
        public string SHARP_LEFT { get; set; }

        /// <summary>
        /// Turn sharp right.
        /// </summary>
        public string SHARP_RIGHT { get; set; }

        /// <summary>
        /// Keep straight on
        /// </summary>
        public string STRAIGHT { get; set; }

        /// <summary>
        /// Switch to the main road.
        /// </summary>
        public string SWITCH_MAIN_ROAD { get; set; }

        /// <summary>
        /// Switch to the parallel road
        /// </summary>
        public string SWITCH_PARALLEL_ROAD { get; set; }

        /// <summary>
        /// Take the exit.
        /// </summary>
        public string TAKE_EXIT { get; set; }

        /// <summary>
        /// Take the ferry
        /// </summary>
        public string TAKE_FERRY { get; set; }

        /// <summary>
        /// Try to make a U-turn
        /// </summary>
        public string TRY_MAKE_UTURN { get; set; }

        /// <summary>
        /// Turn left.
        /// </summary>
        public string TURN_LEFT { get; set; }

        /// <summary>
        /// Turn right.
        /// </summary>
        public string TURN_RIGHT { get; set; }

        /// <summary>
        /// You have reached the waypoint. It is on the left.
        /// </summary>
        public string WAYPOINT_LEFT { get; set; }

        /// <summary>
        /// You have reached the waypoint.
        /// </summary>
        public string WAYPOINT_REACHED { get; set; }

        /// <summary>
        /// You have reached the waypoint. It is on the right.
        /// </summary>
        public string WAYPOINT_RIGHT { get; set; }
    }
}
