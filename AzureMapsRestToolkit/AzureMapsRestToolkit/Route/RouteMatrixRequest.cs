using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Common
{
    public class RouteMatrixRequest : RouteRequestBase
    {
        /// <summary>
        /// The date and time of arrival at the destination point. It must be specified as a dateTime. When a time zone offset is not specified it will be assumed to be that of the destination point. The arriveAt value must be in the future. The arriveAt parameter cannot be used in conjunction with departAt, minDeviationDistance or minDeviationTime.
        /// </summary>
        [JsonPropertyName("arriveAt")]
        public string ArriveAt { get; set; }

        /// <summary>
        /// Specifies which of the section types is reported in the route response.
        /// For example if sectionType = pedestrian the sections which are suited for pedestrians only are returned.Multiple types can be used. The default sectionType refers to the travelMode input. By default travelMode is set to car
        /// </summary>
        [JsonPropertyName("sectionType")]
        public SectionType? SectionType { get; set; }

        /// <summary>
        /// Specifies whether to return additional travel times using different types of traffic information (none, historic, live) as well as the default best-estimate travel time.
        /// </summary>
        [JsonPropertyName("computeTravelTimeFor")]
        public ComputeTravelTimeFor? ComputeTravelTimeFor { get; set; }

        /// <summary>
        /// Boolean to indicate whether to execute the request asynchronously. If set to true, user will get a 202 response right away. Otherwise, user will get a 202 response only if the request takes longer than 20 seconds to finish. Please refer to the API description for more details on 202 response.
        /// </summary>
        [JsonPropertyName("forceAsync")]
        public bool? ForceAsync { get; set; }

    }
}
