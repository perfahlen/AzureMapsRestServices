using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Common
{
    public class RouteRangeRequest : RouteDirectionsRequestBase
    {

        /// <summary>
        /// Fuel budget in liters that determines maximal range which can be travelled using the specified Combustion Consumption Model. Either fuelBudgetInLiters, vehicleEngineType or timeBudgetInSec must be provided.
        /// </summary>
        public string FuelBudgetInLiters { get; set; }

        /// <summary>
        /// Electric energy budget in kilowatt hours (kWh) that determines maximal range which can be travelled using the specified Electric Consumption Model. Either fuelBudgetInLiters, vehicleEngineType or timeBudgetInSec must be provided.
        /// </summary>
        public string EnergyBudgetInkWh { get; set; }

        /// <summary>
        /// Time budget in seconds that determines maximal range which can be travelled using driving time. The consumption parameters will only affect eco-routes and thereby indirectly the driving time. Either fuelBudgetInLiters, vehicleEngineType or timeBudgetInSec must be provided.
        /// </summary>
        public string TimeBudgetInSec { get; set; }


    }
}
