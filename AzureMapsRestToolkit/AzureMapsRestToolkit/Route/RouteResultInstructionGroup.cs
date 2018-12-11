using Newtonsoft.Json;

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
        [JsonProperty("firstInstructionIndex")]
        public int FirstInstructionIndex { get; set; }

        /// <summary>
        /// Length of the group
        /// </summary>
        [JsonProperty("groupLengthInMeters")]
        public int GroupLengthInMeters { get; set; }

        /// <summary>
        /// Summary message when human-readable text messages are requested for guidance (instructionType=text or tagged).
        /// </summary>
        [JsonProperty("groupMessage")]
        public string groupMessage { get; set; }

        /// <summary>
        /// Index of the last instruction.
        /// </summary>
        [JsonProperty("lastInstructionIndex")]
        public int LastInstructionIndex { get; set; }
    }
}
