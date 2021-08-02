using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class HazardDetails
    {
        /// <summary>
        /// A unique identifier (non-displayable) for each type of hazard: LightRain, ModerateRain, HeavyRain, LightMix, ModerateMix, HeavyMix, LightSnow, ModerateSnow, HeavySnow, LightIce, ModerateIce, HeavyIce, Hail, LargeHail, SunGlare, SunGlareHigh, Lightning, SevereLightning, WindModerate, WindHigh, WindExtreme, FloodWarning, FlashFloodWarning, TornadoWarning, TsunamiWarning, SevereThunderstormWarning.
        /// </summary>
        [JsonPropertyName("")]
        public string HazardCode { get; set; }

        /// <summary>
        /// A severity/hazard index.
        /// 0 - No hazard
        /// 1 - Be informed, be aware.
        /// 2 - Pay attention, be prepared.
        /// 3 - Take action.
        /// 4 - Life threatening, emergency.
        /// </summary>
        [JsonPropertyName("hazardIndex")]
        public int HazardIndex { get; set; }

        /// <summary>
        /// A displayable short phrase describing the forecasted conditions and precipitation intensity/type.
        /// </summary>
        [JsonPropertyName("shortPhrase")]
        public string ShortPhrase { get; set; }
    }
}