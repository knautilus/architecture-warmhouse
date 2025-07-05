using Microsoft.AspNetCore.Mvc;

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

            return Ok(temperature);
        }

        /// <summary>
        /// Retrieves temperature by sensor
        /// </summary>
        /// <response code="200">Temperature retreived</response>
        [HttpGet("temperature/{sensorId}")]
        public IActionResult GetTemperatureBySensor([FromRoute] string sensorId)
        {
            var temperature = new Random().Next(-10, 30);

            return Ok(temperature);
        }
    }
}
