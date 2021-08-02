using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class AirAndPollen
    {
        /// <summary>
        /// Category of the air quality or pollution type. For example, low, high, good, moderate, unhealthy, hazardous.
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// Value associated with the air quality or pollution category. These values range from 1 to 6. 1 implying good conditions, 6 implying hazardous conditions.
        /// </summary>
        [JsonPropertyName("categoryValue")]
        public int CategoryValue { get; set; }

        /// <summary>
        /// Name of the pollen or pollutant. For example, grass, mold, weed, air quality, tree and UV index.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Only exists for air quality. Examples include ozone and particle pollution.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Value of the given type above. Values associated with mold, grass, weed and tree are in units of parts per cubic meter. Both air quality and UV are indices, so they are unitless.
        /// </summary>
        [JsonPropertyName("value")]
        public int Value { get; set; }


    }
}