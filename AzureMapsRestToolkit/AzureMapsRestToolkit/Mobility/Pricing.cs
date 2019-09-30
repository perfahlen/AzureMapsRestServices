namespace AzureMapsToolkit.Mobility
{
    public class Pricing
    {
        /// <summary>
        /// The ISO currency code of returned prices. Will be returned in case any of the other pricing fields were returned.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// The price per minute charged when the vehicle has been reserved but not yet in use.
        /// </summary>
        public string ReservationPrice { get; set; }

        /// <summary>
        /// The price per minute charged when the vehicle is in use.
        /// </summary>
        public string UsagePrice { get; set; }
    }
}