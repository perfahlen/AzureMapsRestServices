namespace AzureMapsToolkit.Mobility
{
    public enum DestinationType
    {
        /// <summary>
        /// The origin of the route as a comma separated string composed by latitude followed by longitude e.g. "47.641268,-122.125679".
        /// </summary>
        Position,

        /// <summary>
        /// The unique Azure Maps identifier for the respective public transit stop. When referring stops overtime, it is suggested to use stopId that will not change if the physical stop exists.
        /// </summary>
        StopId,

        /// <summary>
        /// The GTFS stop Id. GTFS stop Ids are provided by the transit authority and are subject to change.
        /// </summary>
        StopKey
    }
}