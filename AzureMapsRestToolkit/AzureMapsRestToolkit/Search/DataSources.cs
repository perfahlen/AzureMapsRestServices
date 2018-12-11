using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    public class DataSources
    {
        /// <summary>
        /// Information about the geometric shape of the result. Only present if type == Geography.
        /// </summary>
        [JsonProperty("geometry")]
        public DataSourcesGeometry Geometry { get; set; }
    }
}