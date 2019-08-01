using AzureMapsToolkit.GeoJson;
using System;

namespace AzureMapsToolkit.Mobility
{
    


 

    public class Leg
    {
        /// <summary>
        /// Relevant for Public Transit and Wait legs only
        /// </summary>
        //public LineArrival[] Departures { get; set; }

        /// <summary>
        /// The walk/bike leg’s destination.
        /// </summary>
        //public LegPoint Destination { get; set; }

        /// <summary>
        /// A valid GeoJSON LineString geometry type. Please refer to RFC 7946 for details.
        /// </summary>
        public LineString Geometry { get; set; }


        /// <summary>
        /// The travel mode of the leg.
        /// </summary>
        //public LegType LegType { get; set; }

        /// <summary>
        /// Start time for the leg.
        /// </summary>
        public DateTime LegStartTime { get; set; }

        /// <summary>
        /// End time for the leg.
        /// </summary>
        public DateTime LegEndTime { get; set; }

        /// <summary>
        /// In case of a public transit leg, the line serving this leg.
        /// </summary>
        public Line Line { get; set; }

        public int MyProperty { get; set; }

        //public Step[] steps { get; set; }
        //public Origin origin { get; set; }
        //public Destination destination { get; set; }
        //public Geometry geometry { get; set; }
    }
}