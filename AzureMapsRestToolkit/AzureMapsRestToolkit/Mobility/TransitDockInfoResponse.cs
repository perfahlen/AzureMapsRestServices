
using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Mobility
{
    public class TransitDockInfoResponse
    {

        /// <summary>
        /// Number of available bikes / scooters in the given bike or scooter docking station.
        /// </summary>
        public int AvailableVehicles { get; set; }

        /// <summary>
        /// When the vacancy and availability information was last updated.
        /// </summary>
        public string LastUpdated { get; set; }

        /// <summary>
        /// Details of the share operator. Id is always returned. Level of other returned details depends on the operator.
        /// </summary>
        public OperatorInfo OperatorInfo { get; set; }

        /// <summary>
        /// The dock's position.
        /// </summary>
        public Coordinate Position { get; set; }

        /// <summary>
        /// Number of vacant dock locations in the given bike or scooter docking station.
        /// </summary>
        public int VacantLocations { get; set; }
    }
}
