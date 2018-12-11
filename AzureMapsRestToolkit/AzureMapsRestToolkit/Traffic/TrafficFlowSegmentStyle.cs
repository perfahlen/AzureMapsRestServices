using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Traffic
{
    /// <summary>
    /// The style to be used to render the tile. Valid values are absolute which returns colors reflecting the absolute speed measured, relative which returns the speed relative to free-flow, Relative-delay which displays relative speeds only where they are different from the freeflow speeds
    /// </summary>
    public enum TrafficFlowSegmentStyle
    {
        //[Display(Name = "absolute")]
        Absolute,
        //public string Absolute { get; set; }

        Relative,
        //public string Relative { get; set; }

        //[Display(Name ="relative-delay")]
        RelativeDelay
        //[NameArgument("relative-delay")]
        //public string RelativeDelay { get; set; }
    }
}