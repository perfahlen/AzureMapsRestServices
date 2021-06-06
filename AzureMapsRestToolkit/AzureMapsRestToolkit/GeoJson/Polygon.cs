using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.GeoJson
{
    /// <summary>
    /// A valid GeoJSON Polygon geometry type. Please refer to RFC 7946 for details.
    /// </summary>
    public class Polygon
    {
        string type = "Polygon";

        /// <summary>
        /// Specifies the type for the object. Value should always be equal to "Polygon".
        /// </summary>
        [JsonPropertyName("type")]
        public string Type
        {
            get { return "Polygon"; }
            set
            {
                if (!string.Equals(value, "Polygon"))
                {
                    throw new System.Exception($"Missmatched geometry type, expected Polygon, recieived {value}");
                }
                type = value;
            }
        }

        /// <summary>
        /// Coordinates for the Polygon geometry type.
        /// </summary>
        [JsonPropertyName("coordinates")]
        public double[][][] Coordinates { get; set; }
    }
}
