using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    /// <summary
    /// Information about the geometric shape of the result. Only present if type == Geography.mmary>
    /// </summary>
    public class DataSourcesGeometry
    {
        /// <summary>
        /// Information about the geometric shape of the result. Only present if type == Geography.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }


    }
}