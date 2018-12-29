namespace AzureMapsToolkit.Common
{

    /// <summary>
    /// The type of route requested.
    /// </summary>
    public enum RouteType
    {
        /// <summary>
        /// A route balanced by economy and speed.
        /// </summary>
        [NameArgument("eco")]
        Eco,

        /// <summary>
        /// The fastest route.
        /// </summary>
        [NameArgument("fastest")]
        Fastest,

        /// <summary>
        /// The shortest route by distance.
        /// </summary>
        [NameArgument("shortest")]
        Shortest,

        /// <summary>
        /// Includes interesting or challenging roads and uses as few motorways as possible. You can choose the level of turns included and also the degree of hilliness. See the hilliness and windingness parameters for how to set this. There is a limit of 900 km on routes planned with routeType=thrilling
        /// </summary>
        [NameArgument("thrilling")]
        Thrilling
    }
}
