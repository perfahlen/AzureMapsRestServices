using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    public class SearchNearbyRequest : SearchRequestBaseExtended
    {
        /// <summary>
        /// Latitude where results should be biased. E.g. 37.337.
        /// </summary>
        [JsonProperty("lat")]
        public string Lat
        { get; set; }


        /// <summary>
        /// Longitude where results should be biased. E.g. -121.89.
        /// </summary>
        [JsonProperty("lon")]
        public string Lon { get; set; }

        /// <summary>
        /// Comma separated string of country codes, e.g. FR, ES. This will limit the search to the specified countries
        /// </summary>
        [JsonProperty("countrySet")]
        public string CountrySet { get; set; }

        /// <summary>
        /// The radius in meters to for the results to be constrained to the defined area, Min value is 1, Max Value is 50000.
        /// </summary>
        [JsonProperty("radius")]
        public double? Radius { get; set; }

    }
}
