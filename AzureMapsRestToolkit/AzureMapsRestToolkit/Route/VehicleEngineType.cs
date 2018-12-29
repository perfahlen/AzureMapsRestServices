using Newtonsoft.Json;

namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// Engine type of the vehicle. When a detailed Consumption Model is specified, it must be consistent with the value of vehicleEngineType
    /// </summary>
    public enum VehicleEngineType
    {
        /// <summary>
        /// Internal combustion engine.
        /// </summary>
        [NameArgument("combustion")]
         Combustion,
        

        /// <summary>
        /// Electric engine.
        /// </summary>
        [NameArgument("electric")]
        Electric

    }
}
