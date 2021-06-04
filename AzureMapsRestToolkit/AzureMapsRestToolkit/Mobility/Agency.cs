using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Mobility
{
    public class Agency
    {
        /// <summary>
        /// The Id of the relevant transit agency, for example, '5872'
        /// </summary>
        [JsonPropertyName("agencyId")]
        public string AgencyId { get; set; }

        /// <summary>
        /// The agency’s GTFS Id.
        /// </summary>
        [JsonPropertyName("agencyKey")]
        public string AgencyKey { get; set; }

        /// <summary>
        /// Name of the relevant transit agency, e.g. Metro Transit.
        /// </summary>
        [JsonPropertyName("agencyName")]
        public string AgencyName { get; set; }

        /// <summary>
        /// Supported public transit type. One of Tram, Subway, Rail, Bus, Ferry, CableCar, Gondola, Funicular.
        /// </summary>
        [JsonPropertyName("transitType")]
        public TransitTypeResult TransitType { get; set; }
    }
}