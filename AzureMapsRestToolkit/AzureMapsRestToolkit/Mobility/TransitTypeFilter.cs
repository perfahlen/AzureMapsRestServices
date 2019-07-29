namespace AzureMapsToolkit.Mobility
{
    /// <summary>
    /// Type of public transit user is requesting respective transit stop, as a comma separated list. If not specified, all will be allowed. This parameter can only be used in conjunction with queryType=stops. Supported transit types are Tram, Subway, Rail, Bus, Ferry, CableCar, Gondola, Funicular. For example, transitType=Bus,Subway.
    /// </summary>
    public class TransitTypeFilter
    {
        /// <summary>
        /// bus
        /// </summary>
        public const string Bus = "bus";

        /// <summary>
        /// Cable car
        /// </summary>
        public const string CableCar = "cableCar";

        /// <summary>
        /// Ferry
        /// </summary>
        public const string Ferry = "ferry";

        /// <summary>
        /// funicular
        /// </summary>
        public const string Funicular = "funicular";

        /// <summary>
        /// gondola
        /// </summary>
        public const string Gondola = "gondola";

        /// <summary>
        /// rail
        /// </summary>
        public const string Rail = "rail";

        /// <summary>
        /// subway
        /// </summary>
        public const string Subway = "subway";

        /// <summary>
        /// tram
        /// </summary>
        public const string Tram = "tram";
    }
}