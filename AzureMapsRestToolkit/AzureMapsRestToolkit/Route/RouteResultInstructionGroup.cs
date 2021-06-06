using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// Groups a sequence of instruction elements which are related to each other. The sequence range is constrained with firstInstructionIndex and lastInstructionIndex. When human-readable text messages are requested for guidance (instructionType=text or tagged), then the instructionGroup has a summary message returned when available.
    /// </summary>
    public class RouteResultInstructionGroup
    {
        /// <summary>
        /// 	Index of the first instruction.
        /// </summary>
        [JsonPropertyName("firstInstructionIndex")]
        public int FirstInstructionIndex { get; set; }

        /// <summary>
        /// Length of the group
        /// </summary>
        [JsonPropertyName("groupLengthInMeters")]
        public int GroupLengthInMeters { get; set; }

        /// <summary>
        /// Summary message when human-readable text messages are requested for guidance (instructionType=text or tagged).
        /// </summary>
        [JsonPropertyName("groupMessage")]
        public string groupMessage { get; set; }

        /// <summary>
        /// Index of the last instruction.
        /// </summary>
        [JsonPropertyName("lastInstructionIndex")]
        public int LastInstructionIndex { get; set; }
    }
}
