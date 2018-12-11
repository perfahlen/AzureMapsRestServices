namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// Specifies something that the route calculation should try to avoid when determining the route. Can be specified multiple times. Possible values: (tollRoads avoids toll roads), (motorways avoids motorways), (ferries avoids ferries), (unpavedRoads avoids unpaved roads), (carpools avoids routes that require use of carpool (HOV/ High Occupancy Vehicle) lanes), (alreadyUsedRoads avoids using the same road multiple times. Most useful in conjunction with routeType=thrilling). In calculateReachableRange requests, the value alreadyUsedRoads must not be used.
    /// </summary>
    public enum Avoid
    {
        /// <summary>
        /// Avoids using the same road multiple times. Most useful in conjunction with routeType=thrilling.
        /// </summary>
        //public const string AlreadyUsedRoads = "alreadyUsedRoads";
        alreadyUsedRoads,

        /// <summary>
        /// Avoids carpools
        /// </summary>
        //public const string Carpools = "carpools";
        carpools,

        /// <summary>
        /// Avoids ferries
        /// </summary>
        //public const string Ferries = "ferries";
        ferries,

        /// <summary>
        /// Avoids motorways
        /// </summary>
        //public const string Motorways = "motorways";
        motorways,

        /// <summary>
        /// Avoids toll roads.
        /// </summary>
        //public const string TollRoads = "tollRoads";
        tollRoads,

        /// <summary>
        /// Avoids unpaved roads
        /// </summary>
        //public const string UnpavedRoads = "unpavedRoads";
        unpavedRoads

    }
}
