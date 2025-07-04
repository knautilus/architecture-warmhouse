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
        public IActionResult GetTemperature([FromQuery] string location)
        {
            var temperature = new Random().Next(-10, 30);

            return Ok(temperature);
        }
    }
}
