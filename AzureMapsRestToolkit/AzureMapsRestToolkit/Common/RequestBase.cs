namespace AzureMapsToolkit.Common
{
    public class RequestBase
    {
        /// <summary>
        /// Version number of Azure Maps API. Current version is 1.0
        /// </summary>
        [NameArgument("api-version")]
        public string ApiVersion { get; set; } = "1.0";
    }
}
