using AzureMapsToolkit.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Common
{
    public class RouteRequestBase : RequestBase
    {
        /// <summary>
        /// Level of turns for thrilling route. This parameter can only be used in conjunction with routeType=thrilling.
        /// </summary>
        public Windingness? Windingness { get; set; }

        /// <summary>
        /// Degree of hilliness for thrilling route. This parameter can only be used in conjunction with routeType=thrilling.
        /// </summary>
        public Hilliness? Hilliness { get; set; }


        /// <summary>
        /// The mode of travel for the requested route. Note that the requested travelMode may not be available for the entire route. Where the requested travelMode is not available for a particular section, the travelMode element of the response for that section will be other. Note that travel modes bus, motorcycle, taxi and van are BETA functionality. Full restriction data is not available in all areas. In calculateReachableRange requests, the values bicycle and pedestrian must not be used
        /// </summary>
        public TravelMode? TravelMode { get; set; }

        /// <summary>
        /// Specifies something that the route calculation should try to avoid when determining the route. Can be specified multiple times. Possible values: (tollRoads avoids toll roads), (motorways avoids motorways), (ferries avoids ferries), (unpavedRoads avoids unpaved roads), (carpools avoids routes that require use of carpool (HOV/ High Occupancy Vehicle) lanes), (alreadyUsedRoads avoids using the same road multiple times. Most useful in conjunction with routeType=thrilling). In calculateReachableRange requests, the value alreadyUsedRoads must not be used
        /// </summary>
        public Avoid? Avoid { get; set; }


        /// <summary>
        /// Possible values:
        /// true - Do consider all available traffic information during routing. 
        /// false - Ignore current traffic data during routing.Note that although the current traffic data is ignored during routing, the effect of historic traffic on effective road speeds is still incorporated.
        /// </summary>
        public bool? Traffic { get; set; }

        /// <summary>
        /// The type of route requested.
        /// </summary>
        public RouteType? RouteType { get; set; }

        /// <summary>
        /// Types of cargo that may be classified as hazardous materials and restricted from some roads. Available vehicleLoadType values are US Hazmat classes 1 through 9, plus generic classifications for use in other countries. Values beginning with USHazmat are for US routing while otherHazmat should be used for all other countries. vehicleLoadType can be specified multiple times. This parameter is currently only considered for travelMode=truck.
        /// </summary>
        public VehicleLoadType? VehicleLoadType { get; set; }

        /// <summary>
        /// Weight of the vehicle in kilograms.
        /// It is mandatory if any of the* Efficiency parameters are set.
        /// It must be strictly positive when used in the context of the Consumption Model.Weight restrictions are considered.
        /// If no detailed Consumption Model is specified and the value of vehicleWeight is non-zero, then weight restrictions are considered.
        /// In all other cases, this parameter is ignored.
        /// Sensible Values : for Combustion Model : 1600, for Electric Model : 1900
        /// </summary>
        public int? VehicleWeight { get; set; }

        /// <summary>
        /// Maximum speed of the vehicle in km/hour.A value of 0 means that an appropriate value for the vehicle will be determined and applied during route planning.A non-zero value may be overridden during route planning.
        /// </summary>
        public int? VehicleMaxSpeed { get; set; }

        /// <summary>
        /// Length of the vehicle in meters. A value of 0 means that length restrictions are not considered.
        /// </summary>
        public float? VehicleLength { get; set; }


        /// <summary>
        /// Height of the vehicle in meters. A value of 0 means that height restrictions are not considered.
        /// </summary>
        public float? VehicleHeight { get; set; }

        /// <summary>
        /// The Coordinates through which the route is calculated, delimited by a colon. A minimum of two coordinates is required. The first one is the origin and the last is the destination of the route. Optional coordinates in-between act as WayPoints in the route. You can pass up to 150 WayPoints.
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// The date and time of departure from the origin point. Departure times apart from now must be specified as a dateTime. When a time zone offset is not specified, it will be assumed to be that of the origin point. The departAt value must be in the future in the date-time format (1996-12-19T16:39:57-08:00).
        /// </summary>
        public string DepartAt { get; set; }

        /// <summary>
        /// Weight per axle of the vehicle in kg. A value of 0 means that weight restrictions per axle are not considered.
        /// </summary>
        public int? VehicleAxleWeight { get; set; }

        /// <summary>
        /// Width of the vehicle in meters. A value of 0 means that width restrictions are not considered.
        /// </summary>
        public float? VehicleWidth { get; set; }

    }
}
