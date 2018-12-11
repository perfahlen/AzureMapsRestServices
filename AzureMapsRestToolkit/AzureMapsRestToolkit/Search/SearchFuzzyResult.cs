using Newtonsoft.Json;
namespace AzureMapsToolkit.Search
{
    public class SearchFuzzyResult : SearchResult
    {
        /// <summary>
        /// The address of the result
        /// </summary>
        [JsonProperty("adress")]
        public SearchResultAddress[] Addresses { get; set; }

        //hack for hiding
        private new SearchResultAddress Address { get; set; }

        /// <summary>
        /// Describes the address range on both sides of the street for a search result. Coordinates for the start and end locations of the address range are included.
        /// </summary>
        [JsonProperty("addressRanges")]
        public SearchResultAddressRanges AddressRanges { get; set; }


        /// <summary>
        /// Optional section. Reference ids for use with the Get Search Polygon API.
        /// </summary>
        [JsonProperty("dataSources")]
        public DataSources DataSources { get; set; }

        /// <summary>
        /// Optional section. Only present if type == Geography. Supported entity types:
        ///  - County
        ///  - CountySubdivision
        ///  - CountrySecondarySubdivision
        ///  - CountryTertiarySubdivision
        ///  - Municipality
        ///  - MunicipalitySubdivision
        ///  - Neighbourhood
        ///  - PostalCodeArea
        /// </summary>
        [JsonProperty("entityType")]
        public string EntityType { get; set; }



        /// <summary>
        /// Info property
        /// </summary>
        [JsonProperty("info")]
        public string Info { get; set; }
    }
}
