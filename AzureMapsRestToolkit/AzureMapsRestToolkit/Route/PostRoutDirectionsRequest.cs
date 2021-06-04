using AzureMapsToolkit.Common;
using System.Text.Json;
using System;

namespace AzureMapsToolkit.Route
{
    public class PostRouteDirectionsRequest : RouteRequestDirections
    {

        // hide intentionally
        [NameArgument("api-version")]
        private new string ApiVersion { get; set; } = "1.0";

    }
}
