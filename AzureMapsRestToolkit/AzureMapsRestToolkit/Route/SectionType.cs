namespace AzureMapsToolkit.Common
{

    /// <summary>
    /// Specifies which of the section types is reported in the route response. 
    /// For example if sectionType = pedestrian the sections which are suited for pedestrians only are returned.Multiple types can be used. The default sectionType refers to the travelMode input. By default travelMode is set to car
    /// </summary>
    public enum SectionType
    {
        /// <summary>
        /// Get sections if the route includes car trains.
        /// </summary>
        carTrain,

        /// <summary>
        /// Countries the route has parts in.
        /// </summary>
        country,


        /// <summary>
        /// Get sections if the route includes ferries.
        /// </summary>
        ferry,

        /// <summary>
        /// Get sections if the route includes motorways.
        /// </summary>
        motorway,

        /// <summary>
        /// Get sections which are suited for pedestrians.
        /// </summary>
        pedestrian,

        /// <summary>
        /// Get sections which require a toll to be payed.
        /// </summary>
        tollRoad,

        /// <summary>
        /// Get sections which require a toll vignette to be present.
        /// </summary>
        tollVignette,

        /// <summary>
        /// Get sections which contain traffic information.
        /// </summary>
        traffic,

        /// <summary>
        /// Get sections in relation to the request parameter travelMode.
        /// </summary>
        travelMode,

        /// <summary>
        /// Get sections if the route includes tunnels.
        /// </summary>
        tunnel
    }
}
