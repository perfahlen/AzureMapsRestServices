using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class Hazards
    {
        /// <summary>
        /// Details of the weather hazards affecting the trip.
        /// </summary>
        [JsonPropertyName("hazardDetails")]
        public HazardDetails[] HazardDetails { get; set; }

        /// <summary>
        /// A severity/hazard index.
        /// 0 - No hazard.
        /// 1 - Be informed, be aware.
        /// 2 - Pay attention, be prepared.
        /// 3 - Take action.
        /// 4 - Life threatening, emergency.
        /// </summary>
        [JsonPropertyName("maxHazardIndex")]
        public int MaxHazardIndex { get; set; }
    }
}