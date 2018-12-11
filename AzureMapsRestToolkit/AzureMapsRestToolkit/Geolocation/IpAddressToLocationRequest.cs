using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Geolocation
{
    internal class IpAddressToLocationRequest : RequestBase
    {
        public string Ip{ get; set; }
    }
}
