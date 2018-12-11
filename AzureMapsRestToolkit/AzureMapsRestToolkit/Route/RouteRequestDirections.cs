using AzureMapsToolkit.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Common
{
    public class RouteRequestDirections : RouteDirectionsRequestBase
    {
        
        /// <summary>
        /// Number of desired alternative routes to be calculated. Default: 0, minimum: 0 and maximum: 5
        /// </summary>
        public int? MaxAlternatives { get; set; }

        /// <summary>
        /// Controls the optimality, with respect to the given planning criteria, of the calculated alternatives compared to the reference route.
        /// </summary>
        public AlternativeRouteType? AlternativeType { get; set; }

        /// <summary>
        /// All alternative routes returned will follow the reference route (see section POST Requests) from the origin point of the calculateRoute request for at least this number of meters. Can only be used when reconstructing a route. The minDeviationDistance parameter cannot be used in conjunction with arriveAt
        /// </summary>
        public int? MinDeviationDistance { get; set; }

        /// <summary>
        /// The date and time of arrival at the destination point. It must be specified as a dateTime. When a time zone offset is not specified it will be assumed to be that of the destination point. The arriveAt value must be in the future. The arriveAt parameter cannot be used in conjunction with departAt, minDeviationDistance or minDeviationTime.
        /// </summary>
        public string ArriveAt { get; set; }


        /// <summary>
        /// All alternative routes returned will follow the reference route (see section POST Requests) from the origin point of the calculateRoute request for at least this number of seconds. Can only be used when reconstructing a route. The minDeviationTime parameter cannot be used in conjunction with arriveAt
        /// </summary>
        public int? MinDeviationTime { get; set; }


        /// <summary>
        /// If specified, guidance instructions will be returned. Note that the instructionsType parameter cannot be used in conjunction with routeRepresentation=none
        /// </summary>
        public RouteInstructionsType? InstructionsType { get; set; }

        /// <summary>
        /// The language parameter determines the language of the guidance messages. It does not affect proper nouns (the names of streets, plazas, etc.) It has no effect when instructionsType=coded. Allowed values are (a subset of) the IETF language tags described
        /// </summary>
        public string Language { get; set; } = "en";

        /// <summary>
        /// Re-order the route waypoints to reduce the route length. Yields best results when used in conjunction with routeType shortest. Possible values are true or false. True computes a better order if possible, but is not allowed to be used in conjunction with maxAlternatives value greater than 0 or in conjunction with circle waypoints. False will use the locations in the given order and not allowed to be used in conjunction with routeRepresentation none.
        /// </summary>
        public bool? ComputeBestOrder { get; set; }

        /// <summary>
        /// Specifies the representation of the set of routes provided as response. This parameter value can only be used in conjunction with computeBestOrder=true.
        /// </summary>
        public RouteRepresentation? RouteRepresentation { get; set; }

        /// <summary>
        /// Specifies whether to return additional travel times using different types of traffic information (none, historic, live) as well as the default best-estimate travel time.
        /// </summary>
        public ComputeTravelTimeFor? ComputeTravelTimeFor { get; set; }

        /// <summary>
        /// The directional heading of the vehicle in degrees starting at true North and continuing in clockwise direction. North is 0 degrees, east is 90 degrees, south is 180 degrees, west is 270 degrees. Possible values 0-359
        /// </summary>
        public int? VehicleHeading { get; set; }

        /// <summary>
        /// Specifies which data should be reported for diagnosis purposes. The only possible value is effectiveSettings. Reports the effective parameters or data used when calling the API. In the case of defaulted parameters the default will be reflected where the parameter was not specified by the caller.
        /// </summary>
        public string Report { get; set; }

        /// <summary>
        /// Specifies which of the section types is reported in the route response. 
        /// For example if sectionType = pedestrian the sections which are suited for pedestrians only are returned.Multiple types can be used. The default sectionType refers to the travelMode input. By default travelMode is set to car
        /// </summary>
        public SectionType? SectionType { get; set; }
       
    }
}
