using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Spatial
{
    public class GeofenceGeometry
    {
        /// <summary>
        /// ID of the device.
        /// </summary>
        [JsonPropertyName("deviceId")]
        public string deviceId { get; set; }

        /// <summary>
        /// Distance from the coordinate to the closest border of the geofence. Positive means the coordinate is outside of the geofence. If the coordinate is outside of the geofence, but more than the value of searchBuffer away from the closest geofence border, then the value is 999. Negative means the coordinate is inside of the geofence. If the coordinate is inside the polygon, but more than the value of searchBuffer away from the closest geofencing border, then the value is -999. A value of 999 means that there is great confidence the coordinate is well outside the geofence. A value of -999 means that there is great confidence the coordinate is well within the geofence.
        /// </summary>
        [JsonPropertyName("distance")]
        public double Distance { get; set; }

        /// <summary>
        /// The unique id identifies a geometry.
        /// </summary>
        [JsonPropertyName("geometryId")]
        public string GeometryId { get; set; }

        /// <summary>
        /// Latitude of the nearest point of the geometry.
        /// </summary>
        [JsonPropertyName("nearestLat")]
        public double NearestLat { get; set; }

        /// <summary>
        /// Longitude of the nearest point of the geometry.
        /// </summary>
        [JsonPropertyName("nearestLon")]
        public double nearestLon { get; set; }


        /// <summary>
        /// The unique id returned from Data Upload API after uploading a valid GeoJSON FeatureCollection object. Please refer to RFC 7946 for details. All the feature's properties should contain geometryId, which is used for identifying the geometry and is case-sensitive.
        /// </summary>
        [JsonPropertyName("udId")]
        public string UdId { get; set; }
    }
}