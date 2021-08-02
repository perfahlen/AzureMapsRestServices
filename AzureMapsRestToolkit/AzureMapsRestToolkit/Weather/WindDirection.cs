using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    /// <summary>
    /// 
    /// </summary>
    public class WindDirection
    {
        /// <summary>
        /// Wind direction in Azimuth degrees, starting at true North and continuing in clockwise direction. North is 0 degrees, east is 90 degrees, south is 180 degrees, west is 270 degrees. Possible values 0-359.
        /// </summary>
        [JsonPropertyName("degrees")]
        public double Degrees { get; set; }

        /// <summary>
        /// Direction abbreviation in the specified language.
        /// </summary>
        [JsonPropertyName("localizedDescription")]
        public string LocalizedDescription { get; set; }

    }
}