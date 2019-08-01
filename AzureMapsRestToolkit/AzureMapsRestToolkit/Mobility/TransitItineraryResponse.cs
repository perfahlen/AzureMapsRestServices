namespace AzureMapsToolkit.Mobility
{
    public class TransitItineraryResponse
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
        /// An array summarizing the legs of this itinerary.
        /// </summary>
        public Leg[] Legs { get; set; }
    }
}
