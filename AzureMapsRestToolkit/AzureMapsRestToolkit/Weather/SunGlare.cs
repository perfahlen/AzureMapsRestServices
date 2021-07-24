using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class SunGlare
    {
        /// <summary>
        /// If the vehicle heading value is not provided for a waypoint, then the service will calculate a heading based upon the location of neighboring waypoints if provided.
        /// </summary>
        [JsonPropertyName("calculatedVehicleHeading")]
        public int calculatedVehicleHeading { get; set; }

        /// <summary>
        /// An index from 0 to 100 indicating sun glare intensity for a driver. A value of 50 and above can be considered a hazard for some drivers and a value of 100 signifies the driver is driving straight into the sun and atmospheric conditions are clear allowing for the full intensity of the sun to blind the driver.
        /// </summary>
        [JsonPropertyName("glareIndex")]
        public int GlareIndex { get; set; }

    }
}