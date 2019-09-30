using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AzureMapsToolkit.Mobility
{
    public class Agency
    {
        /// <summary>
        /// The Id of the relevant transit agency, for example, '5872'
        /// </summary>
        [JsonProperty("agencyId")]
        public string AgencyId { get; set; }

        /// <summary>
        /// The agency’s GTFS Id.
        /// </summary>
        [JsonProperty("agencyKey")]
        public string AgencyKey { get; set; }

        /// <summary>
        /// Name of the relevant transit agency, e.g. Metro Transit.
        /// </summary>
        [JsonProperty("agencyName")]
        public string AgencyName { get; set; }

        /// <summary>
        /// Supported public transit type. One of Tram, Subway, Rail, Bus, Ferry, CableCar, Gondola, Funicular.
        /// </summary>
        [JsonProperty("transitType")]
        public TransitTypeResult TransitType { get; set; }
    }
}