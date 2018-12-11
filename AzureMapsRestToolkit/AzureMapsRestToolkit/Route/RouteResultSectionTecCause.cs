using Newtonsoft.Json;

namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// The cause of the traffic event. Can contain and elements. Can be used to define iconography and descriptions.
    /// </summary>
    public class RouteResultSectionTecCause
    {
        /// <summary>
        /// The main cause of the traffic event. Contains a value in the tec002:CauseCode table, as defined in the TPEG2-TEC standard.
        /// </summary>
        [JsonProperty("mainCauseCode")]
        public int MainCauseCode { get; set; }

        /// <summary>
        /// The subcause of the traffic event. Contains a value in the sub cause table defined by the mainCauseCode, as defined in the TPEG2-TEC standard.
        /// </summary>
        [JsonProperty("subCauseCode")]
        public int SubCauseCode { get; set; }
    }
}
