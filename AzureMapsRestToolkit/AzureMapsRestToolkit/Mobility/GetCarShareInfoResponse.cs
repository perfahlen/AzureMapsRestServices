using AzureMapsToolkit.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Mobility
{
    public class GetCarShareInfoResponse
    {
        /// <summary>
        /// Percentage of fuel indicating the fuel level, 100 being full, 0 empty.
        /// </summary>
        public int FuelLevel { get; set; }

        /// <summary>
        /// Model of the car.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Car share provider spesific value – most often will be the vehicle's license plate.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Details of the share operator.
        /// </summary>
        public OperatorInfo OperatorInfo { get; set; }

        public Coordinate Position { get; set; }

        /// <summary>
        /// Pricing details including currency, reservation price and usage price.
        /// </summary>
        public Pricing Pricing { get; set; }

        /// <summary>
        /// Total number of seats in the vehicle.
        /// </summary>
        public int SeatCount { get; set; }
    }
}
