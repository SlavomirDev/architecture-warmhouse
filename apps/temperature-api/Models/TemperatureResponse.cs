using Newtonsoft.Json;

namespace TemperatureApi.Models;

public class TemperatureResponse
{
    [JsonProperty("value")]
    public float Value { get; set; }

    [JsonProperty("status")]
    public required string Status { get; set; }

    [JsonProperty("location")]
    public required string Location { get; set; }

    [JsonProperty("sensor_id")]
    public required string SensorId { get; set; }

    [JsonProperty("timestamp")]
    public DateTime Timestamp { get; set; }
}
