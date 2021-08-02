using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class DailyIndex
    {
        /// <summary>
        /// Describes the direction of the value and categoryValue. For example, when ascending=True, the poorest index value is 0 and the best index value is 10. When ascending=True, the poorest index value is 10 and the best index value is 0.
        /// </summary>
        [JsonPropertyName("ascending")]
        public bool Ascending { get; set; }

        /// <summary>
        /// "Textual description for categoryValue corresponding to the level that the index value falls under, for example ""Very Good""."
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// Level that the index value falls under, represented by an integer. This value can be 1 through 5 and should be used in combination with the ascending flag because it can differ among indices. For example, the following values apply for Mosquito Activity: Low=1, Moderate=2, High=3, Very High=4, and Extreme=5.
        /// </summary>
        [JsonPropertyName("categoryValue")]
        public int CategoryValue { get; set; }

        /// <summary>
        /// Date and time of the current observation displayed in ISO 8601 format, for example, 2019-10-27T19:39:57-08:00.
        /// </summary>
        [JsonPropertyName("dateTime")]
        public string DateTime { get; set; }

        /// <summary>
        /// "A textual explanation that can be used for display purposes to summarize the index value and category. For example, when the index value for Flight Delays is very good, the description will be ""Conditions are excellent for flying!""."
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Numeric ID used to identify the specific index. Please refer to Weather Service Concepts for details and to see the supported index IDs. For example, the index ID can support UI visualization scenarios.
        /// </summary>
        [JsonPropertyName("indexId")]
        public int IndexId { get; set; }

        /// <summary>
        /// "Name of the index, for example, ""Construction"", ""Outdoor Activity"", ""Flight Delays""."
        /// </summary>
        [JsonPropertyName("indexName")]
        public string IndexName { get; set; }

        /// <summary>
        /// Index value. Ranges from 0.0 to 10.0. Please refer to Weather Service Concepts for details and to see the supported ranges.
        /// </summary>
        [JsonPropertyName("value")]
        public double Value { get; set; }


    }
}