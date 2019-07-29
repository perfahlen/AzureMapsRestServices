namespace AzureMapsToolkit.Mobility
{
    /// <summary>
    /// This object is returned from a successful Get Real Time Arrival Info call.
    /// </summary>
    public class RealTimeArrivalsResponse
    {
        /// <summary>
        /// Results array. Contains results related details.
        /// </summary>
        public RealTimeArrivalResult[] Results { get; set; }
    }
}
