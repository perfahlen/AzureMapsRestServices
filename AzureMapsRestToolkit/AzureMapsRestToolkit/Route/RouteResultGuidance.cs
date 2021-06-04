using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// Contains guidance related elements. This field is present only when guidance was requested and is available.
    /// </summary>
    public class RouteResultGuidance
    {
        /// <summary>
        /// Groups a sequence of instruction elements which are related to each other.
        /// </summary>
        [JsonPropertyName("instructionGroups")]
        public RouteResultInstructionGroup[] InstructionGroups { get; set; }

        /// <summary>
        /// A list of instructions describing maneuvers.
        /// </summary>
        [JsonPropertyName("instructions")]
        public RouteResultInstruction[] Instructions { get; set; }
    }
}
