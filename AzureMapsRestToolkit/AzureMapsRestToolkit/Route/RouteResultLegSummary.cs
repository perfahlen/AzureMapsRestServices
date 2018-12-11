using Newtonsoft.Json;

namespace AzureMapsToolkit.Common
{
    public class RouteResultLegSummary
    {
        /// <summary>
        /// Arrival Time property
        /// </summary>
        [JsonProperty("arrivalTime")]
        public string ArrivalTime { get; set; }

        /// <summary>
        /// Estimated electric energy consumption in kilowatt hours (kWh) using the Electric Consumption Model. Included if vehicleEngineType is set to electric and constantSpeedConsumptionInkWhPerHundredkm is specified. The value of batteryConsumptionInkWh includes the recuperated electric energy and can therefore be negative (which indicates gaining energy). If both maxChargeInkWh and currentChargeInkWh are specified, recuperation will be capped to ensure that the battery charge level never exceeds maxChargeInkWh. If neither maxChargeInkWh nor currentChargeInkWh are specified, unconstrained recuperation is assumed in the consumption calculation.
        /// </summary>
        [JsonProperty("batteryConsumptionInkWh")]
        public float BatteryConsumptionInkWh { get; set; }

        /// <summary>
        /// Departure Time property
        /// </summary>
        [JsonProperty("departureTime")]
        public string DepartureTime { get; set; }

        /// <summary>
        /// Estimated fuel consumption in liters using the Combustion Consumption Model. Included if vehicleEngineType is set to combustion and constantSpeedConsumptionInLitersPerHundredkm is specified. The value will be non-negative.
        /// </summary>
        [JsonProperty("fuelConsumptionInLiters")]
        public float FuelConsumptionInLiters { get; set; }

        /// <summary>
        /// Estimated travel time calculated using time-dependent historic traffic data. Included only if computeTravelTimeFor = all is used in the query.
        /// </summary>
        [JsonProperty("historicTrafficTravelTimeInSeconds")]
        public int HistoricTrafficTravelTimeInSeconds { get; set; }

        /// <summary>
        /// Length In Meters property
        /// </summary>
        [JsonProperty("lengthInMeters")]
        public int LengthInMeters { get; set; }

        /// <summary>
        /// Estimated travel time calculated using real-time speed data. Included only if computeTravelTimeFor = all is used in the query.
        /// </summary>
        [JsonProperty("liveTrafficIncidentsTravelTimeInSeconds")]
        public int LiveTrafficIncidentsTravelTimeInSeconds { get; set; }

        /// <summary>
        /// Estimated travel time calculated as if there are no delays on the route due to traffic conditions (e.g. congestion). Included only if computeTravelTimeFor = all is used in the query.
        /// </summary>
        [JsonProperty("noTrafficTravelTimeInSeconds")]
        public int NoTrafficTravelTimeInSeconds { get; set; }

        /// <summary>
        /// Traffic Delay In Seconds property
        /// </summary>
        [JsonProperty("trafficDelayInSeconds")]
        public int TrafficDelayInSeconds { get; set; }

        /// <summary>
        /// Estimated travel Time In Seconds property
        /// </summary>
        [JsonProperty("travelTimeInSeconds")]
        public int TravelTimeInSeconds { get; set; }

    }
}
