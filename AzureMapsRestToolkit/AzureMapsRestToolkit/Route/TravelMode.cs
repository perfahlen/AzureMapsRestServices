namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// The mode of travel for the requested route. Note that the requested travelMode may not be available for the entire route. Where the requested travelMode is not available for a particular section, the travelMode element of the response for that section will be other. Note that travel modes bus, motorcycle, taxi and van are BETA functionality. Full restriction data is not available in all areas. In calculateReachableRange requests, the values bicycle and pedestrian must not be used
    /// </summary>
    public enum TravelMode
    {
        bicycle,
        bus,
        car,
        motorcycle,
        pedestrian,
        taxi,
        truck,
        van
    }
}
