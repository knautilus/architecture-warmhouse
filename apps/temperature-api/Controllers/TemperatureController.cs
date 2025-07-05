using Microsoft.AspNetCore.Mvc;
using TemperatureApi.Models;

namespace TemperatureApi.Controllers
{
    [ApiController]
    public class TemperatureController : Controller
    {
        /// <summary>
        /// Retrieves temperature by location
        /// </summary>
        /// <response code="200">Temperature retreived</response>
        [HttpGet("temperature")]
        public IActionResult GetTemperatureByLocation([FromQuery] string location)
        {
            var temperature = new Random().Next(-10, 30);

            return Ok(new TemperatureResponse
            {
                Value = temperature,
                Location = location,
                SensorType = "Temperature",
                Status = "Ok",
                Unit = "Degree Celsius",
            });
        }

        /// <summary>
        /// Retrieves temperature by sensor
        /// </summary>
        /// <response code="200">Temperature retreived</response>
        [HttpGet("temperature/{sensorId}")]
        public IActionResult GetTemperatureBySensor([FromRoute] string sensorId)
        {
            var temperature = new Random().Next(-10, 30);

            return Ok(new TemperatureResponse
            {
                Value = temperature,
                SensorID = sensorId,
                SensorType = "Temperature",
                Status = "Ok",
                Unit = "Degree Celsius",
            });
        }
    }
}
