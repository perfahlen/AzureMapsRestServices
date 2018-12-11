using Newtonsoft.Json;

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
        [JsonProperty("instructionGroups")]
        public RouteResultInstructionGroup[] InstructionGroups { get; set; }

        /// <summary>
        /// A list of instructions describing maneuvers.
        /// </summary>
        [JsonProperty("instructions")]
        public RouteResultInstruction[] Instructions { get; set; }
    }
}
