namespace AzureMapsToolkit.Mobility
{
    public enum StopQueryType
    {
        /// <summary>
        /// The unique identifier for the respective public transit stop. When referring stops overtime, it is suggested to use stopId that will not change if the physical stop exists.
        /// </summary>
        StopId,

        /// <summary>
        /// The GTFS stop Id. GTFS stop Ids are provided by the transit authority and are subject to change.
        /// </summary>
        StopKey
    }
}