namespace AzureMapsToolkit.Timezone
{
    /// <summary>
    /// Alternatively, use alias "o". Options available for types of information returned in the result.
    /// </summary>
    public enum TimezoneOptions
    {
        /// <summary>
        /// Include both zoneinfo and transitions in the result.
        /// </summary>
        All,
        //public string All { get; set; }

        /// <summary>
        /// Do not include zoneinfo or transitions in the result.
        /// </summary>
        None,
        //public string None { get; set; }

        /// <summary>
        /// Include transition information in the result (The number of transitions is currently capped at 250).
        /// </summary>
        Transitions,
        //public int? Transitions { get; set; }


        /// <summary>
        /// Include additional time zone info in the result.
        /// </summary>
        ZoneInfo
        ///public string ZoneInfo { get; set; }
    }
}