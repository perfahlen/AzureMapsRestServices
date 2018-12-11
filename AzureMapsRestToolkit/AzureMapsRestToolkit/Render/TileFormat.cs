namespace AzureMapsToolkit.Render
{
    /// <summary>
    /// Desired format of the response. Possible values are png & pbf.
    /// </summary>
    public enum TileFormat
    {
        /// <summary>
        /// Vector graphic in the pbf format. Supports zoom levels 0 through 20.
        /// </summary>
        //public const string PNG = "png";
        png,

        /// <summary>
        /// An image in the png format. Supports zoom levels 0 through 18.
        /// </summary>
        //public const string PBF = "pbf";
        pbf
    }
}
