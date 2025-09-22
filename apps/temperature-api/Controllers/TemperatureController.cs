using Microsoft.AspNetCore.Mvc;

using TemperatureApi.Models;

namespace TemperatureApi.Controllers;

[ApiController]
[Route("temperature")]
public class TemperatureController : ControllerBase
{
    [HttpGet("{id}")]
    public TemperatureResponse GetTemperature([FromRoute(Name = "id")] string sensorId, [FromQuery(Name = "location")] string? location = null)
    {
        return new TemperatureResponse()
        {
            Value = Random.Shared.Next(0, 36),
            Status = "Ok",
            Location = location ?? "Unknown",
            SensorId = sensorId,
            Timestamp = DateTime.Now
        };
    }
}
