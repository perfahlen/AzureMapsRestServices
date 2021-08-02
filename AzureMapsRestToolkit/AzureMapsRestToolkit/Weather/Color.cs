using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class Color
    {
        /// <summary>
        /// Blue component of the RGB value
        /// </summary>
        [JsonPropertyName("blue")]
        public int Blue { get; set; }

        /// <summary>
        /// Green component of the RGB value.
        /// </summary>
        [JsonPropertyName("green")]
        public int Green { get; set; }

        /// <summary>
        /// Hexadecimal color value.
        /// </summary>
        [JsonPropertyName("hex")]
        public string Hex { get; set; }

        /// <summary>
        /// Red component of the RGB value.
        /// </summary>
        [JsonPropertyName("red")]
        public int Red { get; set; }


    }
}