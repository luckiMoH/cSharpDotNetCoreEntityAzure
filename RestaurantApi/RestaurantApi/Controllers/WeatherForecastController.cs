using Microsoft.AspNetCore.Mvc;

namespace RestaurantApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForcastService _service;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForcastService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost("generate")]
        public ActionResult<IEnumerable<WeatherForecast>> Generate([FromQuery] int resultsCount, [FromBody] TemperatureRequest request)
        {
            if (resultsCount < 0 || request.Max < request.Min)
            {
                return BadRequest();
            }

            var result = _service.Get(resultsCount, request.Min, request.Max);
            return Ok(result);
        }
    }
}
