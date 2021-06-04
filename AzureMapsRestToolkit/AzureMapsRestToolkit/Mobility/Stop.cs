using AzureMapsToolkit.Common;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Mobility
{
    /// <summary>
    /// The stop's basic info
    /// </summary>
    public class Stop
    {
        /// <summary>
        /// The Id of the transit agency of most lines stopping at this stop. For example '5872'.
        /// </summary>
        public string MainAgencyId { get; set; }

        /// <summary>
        /// The name of the agency of most lines stopping at this stop, for example, 'Metro Transit'.
        /// </summary>
        public string MainAgencyName { get; set; }

        /// <summary>
        /// The transit type of most lines stopping at this stop. One of Tram, Subway, Rail, Bus, Ferry, CableCar, Gondola, Funicular
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TransitType MainTransitType { get; set; }

        /// <summary>
        /// The Stop's location, latitude and longitude.
        /// </summary>
        public Coordinate Position { get; set; }

        /// <summary>
        /// The stop code displayed at the physical stop. Returned if available.
        /// </summary>
        public string StopCode { get; set; }

        /// <summary>
        /// The unique Azure Maps identifier for the respective public transit stop. When referring stops overtime, it is suggested to use stopId that will not change if the physical stop exists.
        /// </summary>
        public string StopId { get; set; }

        /// <summary>
        /// The GTFS stop Id. GTFS stop Ids are provided by the transit authority and subject to change.
        /// </summary>
        public string StopKey { get; set; }

        /// <summary>
        /// The name of the stop.
        /// </summary>
        public string StopName { get; set; }
    }
}