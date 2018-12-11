namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// Types of cargo that may be classified as hazardous materials and restricted from some roads. Available vehicleLoadType values are US Hazmat classes 1 through 9, plus generic classifications for use in other countries. Values beginning with USHazmat are for US routing while otherHazmat should be used for all other countries. vehicleLoadType can be specified multiple times. This parameter is currently only considered for travelMode=truck.
    /// </summary>
    public enum VehicleLoadType
    {
        /// <summary>
        /// Explosives
        /// </summary>
        USHazmatClass1,

        /// <summary>
        /// Compressed gas
        /// </summary>
        USHazmatClass2,

        /// <summary>
        /// Flammable liquids
        /// </summary>
        USHazmatClass3,

        /// <summary>
        /// Flammable solids
        /// </summary>
        USHazmatClass4,

        /// <summary>
        /// Oxidizers
        /// </summary>
        USHazmatClass5,

        /// <summary>
        /// Poisons
        /// </summary>
        USHazmatClass6,

        /// <summary>
        /// Radioactive
        /// </summary>
        USHazmatClass7,

        /// <summary>
        /// Corrosives
        /// </summary>
        USHazmatClass8,

        /// <summary>
        /// Miscellaneous
        /// </summary>
        USHazmatClass9,

        /// <summary>
        /// Explosives
        /// </summary>
        otherHazmatExplosive,

        /// <summary>
        /// Miscellaneous
        /// </summary>
        otherHazmatGeneral,

        /// <summary>
        /// Harmful to water
        /// </summary>
        otherHazmatHarmfulToWater
    }
}
