using AzureMapsToolkit.GeoJson;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AzureMapsToolkit.Mobility
{

    public class Leg
    {
        /// <summary>
        /// Relevant for Public Transit and Wait legs only
        /// </summary>
        public LineArrival[] Departures { get; set; }

        /// <summary>
        /// The walk/bike leg’s destination.
        /// </summary>
        public LegPoint Destination { get; set; }

        /// <summary>
        /// A valid GeoJSON LineString geometry type. Please refer to RFC 7946 for details.
        /// </summary>
        public LineString Geometry { get; set; }

        /// <summary>
        /// End time for the leg.
        /// </summary>
        public DateTime LegEndTime { get; set; }

        /// <summary>
        /// Start time for the leg.
        /// </summary>
        public DateTime LegStartTime { get; set; }


        /// <summary>
        /// The travel mode of the leg.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public LegType LegType { get; set; }


        /// <summary>
        /// In case of a public transit leg, the line serving this leg.
        /// </summary>
        public Line Line { get; set; }

        /// <summary>
        /// In case of a public transit leg, the line group serving this leg.
        /// </summary>
        public LineGroup LineGroup { get; set; }

        /// <summary>
        /// The walk/bike leg’s origin.
        /// </summary>
        public LegPoint Origin { get; set; }

        /// <summary>
        /// List of stops comprising the line’s route within the leg (e.g. the stops the leg passes through).
        /// </summary>
        public Stop[] Stops { get; set; }

        /// <summary>
        /// Indicates whether it’s necessary to wait for the next leg on the same vehicle (i.e. the bus will only change its line number).
        /// </summary>
        public string WaitOnVehicle { get; set; }

    }
}