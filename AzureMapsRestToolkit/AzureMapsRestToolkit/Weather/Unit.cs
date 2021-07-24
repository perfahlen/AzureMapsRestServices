namespace AzureMapsToolkit.Weather
{
    /// <summary>
    /// Specifies to return the data in either metric units or imperial units. Default value is metric.
    /// </summary>
    public enum Unit
    {
        /// <summary>
        /// Return data in imperial units. Some example units of imperial system are Fahrenheit and mile.
        /// </summary>
        imperial,
        
        /// <summary>
        /// Return data in metric units. Some example units of metric system are Celsius and kilometer.
        /// </summary>
        metric
    }
}