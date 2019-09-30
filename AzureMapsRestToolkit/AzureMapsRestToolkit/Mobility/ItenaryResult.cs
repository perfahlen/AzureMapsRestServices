namespace AzureMapsToolkit.Mobility
{
    public class ItenaryResult
    {
        /// <summary>
        /// The date and time of arrival at the destination point in ISO 8601 format, e.g. 1996-12-19T19:39:57-08:00.
        /// </summary>
        public string ArrivalTime { get; set; }

        /// <summary>
        /// The date and time of departure from the origin point in ISO 8601 format, e.g. 1996-12-19T16:39:57-08:00.
        /// </summary>
        public string DepartureTime { get; set; }

        /// <summary>
        /// A unique identifier of the returned itinerary.
        /// </summary>
        public string ItineraryId { get; set; }

        /// <summary>
        /// An array summarizing the legs of this itinerary.
        /// </summary>
        public RouteItenaryLeg[] Legs { get; set; }

        /// <summary>
        /// Number of legs.
        /// </summary>
        public uint NumberOfLegs { get; set; }

        /// <summary>
        /// Estimated travel time in seconds.
        /// </summary>
        public uint TravelTimeInSeconds { get; set; }
    }
}