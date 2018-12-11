namespace AzureMapsToolkit.Traffic
{
    /// <summary>
    /// The type of vector geometry added to incidents (returned in the element of the response).
    /// </summary>
    public class IncidentGeometryType
    {
        /// <summary>
        /// Places incidents precisely on the road.
        /// </summary>
        public string Original { get; set; }

        /// <summary>
        /// Moves the incident slightly (depending on zoom level) to indicate specific road lanes.
        /// </summary>
        public string Shifted { get; set; }
    }
}