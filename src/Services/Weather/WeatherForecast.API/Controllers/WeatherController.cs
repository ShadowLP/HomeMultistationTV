using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Weather.Domain.Entity;
using Weather.Domain.Interface.Service;

namespace Weather.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherGetterService _weatherGetterService;
        private readonly ILogger<WeatherController> _logger;

        public WeatherController(
             IWeatherGetterService weatherGetterService,
             ILogger<WeatherController> logger)
         {
            _weatherGetterService = weatherGetterService;
            _logger = logger;
        }

        // GET api/weather
        [HttpGet]
        [Route("city/{cityName}")]
        public async Task<ActionResult<WeatherDto>> Get(string cityName)
        {
            _logger.LogTrace($"Create request weather/city/{cityName}");
            WeatherDto result = await _weatherGetterService.GetWeather(cityName);
            _logger.LogTrace($"End request weather/city/{cityName}");
            return result;
        }

        [HttpGet]
        [Route("location/{log}/{lan}")]
        public async Task<ActionResult<WeatherDto>> Get(double log, double lan)
        {
            _logger.LogTrace($"Create request weather/city/{log}/{lan}");
            var result = await _weatherGetterService.GetWeather(new LocationDto { Longitude = log, Latitude = lan });
            _logger.LogTrace($"Create request weather/city//{log}/{lan}");

            return result;
        }
    }
}
