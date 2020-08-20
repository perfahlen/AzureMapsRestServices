using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Mobility
{
    /// <summary>
    /// The type of route requested. If not specified, 'optimal' will be used.
    /// </summary>
    public enum TransitRouteType
    {
        /// <summary>
        /// Route with least transfers.
        /// </summary>
        //public string LeastTransfers { get; set; }
        LeastTransfers,


        /// <summary>
        /// Route with least walk.
        /// </summary>
        //public string LeastWalk { get; set; }
        LeastWalk,

        /// <summary>
        /// The best optimal route.
        /// </summary>
        //public string Optimal { get; set; }
        Optimal
}
}
