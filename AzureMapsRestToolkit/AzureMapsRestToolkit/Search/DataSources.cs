using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Search
{
    public class DataSources
    {
        /// <summary>
        /// Information about the geometric shape of the result. Only present if type == Geography.
        /// </summary>
        [JsonPropertyName("geometry")]
        public DataSourcesGeometry Geometry { get; set; }
    }
}