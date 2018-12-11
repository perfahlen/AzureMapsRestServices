using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Common
{
    public class RouteDirectionsRequestBase : RouteRequestBase
    {
        /// <summary>
        /// 
        /// </summary>
        public VehicleEngineType? VehicleEngineType { get; set; }

        /// <summary>
        /// 	Specifies the speed-dependent component of consumption.
        /// 	Provided as an unordered list of colon-delimited speed & consumption-rate pairs. The list defines points on a consumption curve. Consumption rates for speeds not in the list are found as follows:
        /// 	by linear interpolation, if the given speed lies in between two speeds in the list
        /// 	by linear extrapolation otherwise, assuming a constant (ΔConsumption/ΔSpeed) determined by the nearest two points in the list
        /// 	The list must contain between 1 and 25 points(inclusive), and may not contain duplicate points for the same speed.If it only contains a single point, then the consumption rate of that point is used without further processing.
        /// 	Consumption specified for the largest speed must be greater than or equal to that of the penultimate largest speed. This ensures that extrapolation does not lead to negative consumption rates.
        /// 	Similarly, consumption values specified for the two smallest speeds in the list cannot lead to a negative consumption rate for any smaller speed.
        /// 	The valid range for the consumption values(expressed in l/100km) is between 0.01 and 100000.0.
        /// 	Sensible Values : 50,6.3:130,11.5
        /// 	Note : This parameter is required for The Combustion Consumption Model.
        /// </summary>
        public float? ConstantSpeedConsumptionInLitersPerHundredkm { get; set; }

        /// <summary>
        /// Specifies the amount of fuel consumed for sustaining auxiliary systems of the vehicle, in liters per hour.
        /// It can be used to specify consumption due to devices and systems such as AC systems, radio, heating, etc.
        /// Sensible Values : 0.2
        /// </summary>
        public float? AuxiliaryPowerInLitersPerHour { get; set; }

        /// <summary>
        /// Specifies the amount of chemical energy stored in one liter of fuel in megajoules (MJ). It is used in conjunction with the **Efficiency* parameters for conversions between saved or consumed energy and fuel. For example, energy density is 34.2 MJ/l for gasoline, and 35.8 MJ/l for Diesel fuel.
        /// This parameter is required if any** Efficiency* parameter is set
        /// Sensible Values : 34.2
        /// </summary>
        public float? FuelEnergyDensityInMJoulesPerLiter { get; set; }

        /// <summary>
        /// Specifies the efficiency of converting chemical energy stored in fuel to kinetic energy when the vehicle accelerates (i.e. KineticEnergyGained/ChemicalEnergyConsumed). ChemicalEnergyConsumed is obtained by converting consumed fuel to chemical energy using fuelEnergyDensityInMJoulesPerLiter.
        /// Must be paired with decelerationEfficiency.
        /// The range of values allowed are 0.0 to 1/decelerationEfficiency.
        /// Sensible Values : for Combustion Model : 0.33, for Electric Model : 0.66
        /// </summary>
        public float? AccelerationEfficiency { get; set; }

        /// <summary>
        /// Specifies the efficiency of converting kinetic energy to saved (not consumed) fuel when the vehicle decelerates (i.e. ChemicalEnergySaved/KineticEnergyLost). ChemicalEnergySaved is obtained by converting saved (not consumed) fuel to energy using fuelEnergyDensityInMJoulesPerLiter.
        /// Must be paired with accelerationEfficiency.
        /// The range of values allowed are 0.0 to 1/accelerationEfficiency.
        /// Sensible Values : for Combustion Model : 0.83, for Electric Model : 0.91
        /// </summary>
        public float? DecelerationEfficiency { get; set; }

        /// <summary>
        /// Specifies the efficiency of converting chemical energy stored in fuel to potential energy when the vehicle gains elevation (i.e. PotentialEnergyGained/ChemicalEnergyConsumed). ChemicalEnergyConsumed is obtained by converting consumed fuel to chemical energy using fuelEnergyDensityInMJoulesPerLiter.
        /// Must be paired with downhillEfficiency.
        /// The range of values allowed are 0.0 to 1/downhillEfficiency.
        /// Sensible Values : for Combustion Model : 0.27, for Electric Model : 0.74
        /// </summary>
        public float? UphillEfficiency { get; set; }

        /// <summary>
        /// Specifies the efficiency of converting potential energy to saved (not consumed) fuel when the vehicle loses elevation (i.e. ChemicalEnergySaved/PotentialEnergyLost).ChemicalEnergySaved is obtained by converting saved (not consumed) fuel to energy using fuelEnergyDensityInMJoulesPerLiter.
        /// Must be paired with uphillEfficiency.
        /// The range of values allowed are 0.0 to 1/uphillEfficiency.
        /// Sensible Values : for Combustion Model : 0.51, for Electric Model : 0.73
        /// </summary>
        public float? DownhillEfficiency { get; set; }

        /// <summary>
        /// Specifies the speed-dependent component of consumption.
        /// Provided as an unordered list of speed/consumption-rate pairs.The list defines points on a consumption curve.Consumption rates for speeds not in the list are found as follows:
        /// by linear interpolation, if the given speed lies in between two speeds in the list
        /// by linear extrapolation otherwise, assuming a constant (ΔConsumption/ΔSpeed) determined by the nearest two points in the list
        /// The list must contain between 1 and 25 points(inclusive), and may not contain duplicate points for the same speed.If it only contains a single point, then the consumption rate of that point is used without further processing.
        /// Consumption specified for the largest speed must be greater than or equal to that of the penultimate largest speed. This ensures that extrapolation does not lead to negative consumption rates.
        /// Similarly, consumption values specified for the two smallest speeds in the list cannot lead to a negative consumption rate for any smaller speed.
        /// The valid range for the consumption values(expressed in kWh/100km) is between 0.01 and 100000.0.
        /// Sensible Values : 50,8.2:130,21.3
        /// This parameter is required for Electric consumption model.
        /// </summary>
        public float? ConstantSpeedConsumptionInkWhPerHundredkm { get; set; }

        /// <summary>
        /// Specifies the maximum electric energy supply in kilowatt hours (kWh) that may be stored in the vehicle's battery.
        /// This parameter co-exists with currentChargeInkWh parameter.
        /// Minimum value has to be greater than or equal to currentChargeInkWh.
        /// Sensible Values : 85 
        /// </summary>
        public string MaxChargeInkWh { get; set; }

        /// <summary>
        /// Specifies the current electric energy supply in kilowatt hours (kWh).
        /// This parameter co-exists with maxChargeInkWh parameter.
        /// The range of values allowed are 0.0 to maxChargeInkWh.
        /// Sensible Values : 43
        /// </summary>
        public string CurrentChargeInkWh { get; set; }

        /// <summary>
        /// Specifies the current supply of fuel in liters.
        /// Sensible Values : 55
        /// </summary>
        public float? CurrentFuelInLiters { get; set; }

        /// <summary>
        /// Specifies the amount of power consumed for sustaining auxiliary systems, in kilowatts (kW).
        /// It can be used to specify consumption due to devices and systems such as AC systems, radio, heating, etc.
        /// Sensible Values : 1.7
        /// </summary>
        public string AuxiliaryPowerInkW { get; set; }

    }
}
