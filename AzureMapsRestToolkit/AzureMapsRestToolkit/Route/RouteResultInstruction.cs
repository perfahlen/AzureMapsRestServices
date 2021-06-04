using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// A set of attributes describing a maneuver, e.g. 'Turn right', 'Keep left', 'Take the ferry', 'Take the motorway', 'Arrive'.
    /// </summary>
    public class RouteResultInstruction
    {
        /// <summary>
        /// 3-character ISO 3166-1 alpha-3 country code. E.g. USA
        /// </summary>
        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Indicates left-hand vs. right-hand side driving at the point of the maneuver.
        /// </summary>
        [JsonPropertyName("drivingSide")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DrivingSide DrivingSide { get; set; }

        /// <summary>
        /// Type of the instruction, e.g., turn or change of road form.
        /// </summary>
        [JsonPropertyName("instructionType")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public GuidanceInstructionType instructionType { get; set; }

        /// <summary>
        /// A code identifying the maneuver.
        /// </summary>
        [JsonPropertyName("maneuver")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public GuidanceManeuver Maneuver { get; set; }

        /// <summary>
        /// A human-readable message for the maneuver.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// A location represented as a latitude and longitude.
        /// </summary>
        [JsonPropertyName("point")]
        public Coordinate Point { get; set; }

        /// <summary>
        /// It is possible to optionally combine the instruction with the next one. This can be used to build messages like "Turn left and then turn right".
        /// </summary>
        [JsonPropertyName("possibleCombineWithNext")]
        public bool PossibleCombineWithNext { get; set; }

        /// <summary>
        /// Distance from the start of the route to the point of the instruction.
        /// </summary>
        [JsonPropertyName("routeOffsetInMeters")]
        public int RouteOffsetInMeters { get; set; }

        /// <summary>
        /// Street name of the next significant road segment after the maneuver, or of the street that should be followed.
        /// </summary>
        [JsonPropertyName("street")]
        public string Street { get; set; }

        /// <summary>
        /// Estimated travel time up to the point corresponding to routeOffsetInMeters.
        /// </summary>
        [JsonPropertyName("travelTimeInSeconds")]
        public int TravelTimeInSeconds { get; set; }
    }
}
