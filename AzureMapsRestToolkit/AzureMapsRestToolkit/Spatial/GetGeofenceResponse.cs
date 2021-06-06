using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Spatial
{
    /// <summary>
    /// This object is returned from a geofence proximity call.
    /// </summary>
    public class GeofenceResponse
    {
        /// <summary>
        /// Lists of the geometry ID of the geofence which is expired relative to the user time in the request.
        /// </summary>
        [JsonPropertyName("expiredGeofenceGeometryId")]
        public string[] ExpiredGeofenceGeometryId { get; set; }

        /// <summary>
        /// Lists the fence geometries that contain the coordinate position or overlap the searchBuffer around the position.
        /// </summary>
        [JsonPropertyName("geometries")]
        public GeofenceGeometry[] Geometries { get; set; }

        /// <summary>
        /// Lists of the geometry ID of the geofence which is in invalid period relative to the user time in the request.
        /// </summary>
        [JsonPropertyName("InvalidPeriodGeofenceGeometryId")]
        public string[] InvalidPeriodGeofenceGeometryId { get; set; }

        /// <summary>
        /// True if at least one event is published to the Azure Maps event subscriber, false if no event is published to the Azure Maps event subscriber.
        /// </summary>
        [JsonPropertyName("isEventPublished")]
        public bool IsEventPublished { get; set; }
    }
}
