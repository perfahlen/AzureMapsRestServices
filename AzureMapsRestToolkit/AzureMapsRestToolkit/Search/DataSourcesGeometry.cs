using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    public class DataSourcesGeometry
    {
        /// <summary
        /// Information about the geometric shape of the result. Only present if type == Geography.mmary>
        /// </summary>
        [JsonProperty("Pass this as geometryId to the Get Search Polygon API to fetch geometry information for this result.")]
        public string Id { get; set; }


    }
}