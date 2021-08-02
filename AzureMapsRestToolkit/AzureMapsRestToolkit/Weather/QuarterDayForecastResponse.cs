using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AzureMapsToolkit.Weather
{
    public class QuarterDayForecastResponse
    {
        /// <summary>
        /// Forecast data for each quarter in the response.
        /// </summary>
        [JsonPropertyName("forecasts")]
        public QuarterDayForecast[] Forecasts { get; set; }
    }
}
