using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using Weather.Domain.Entity;
using Weather.Domain.Interface.Service;
using Weather.Infrastructure.Interface;

namespace Weather.Infrastructure.Service
{
    public class OpenWeatherMapWeatherGetterService : IWeatherGetterService
    {
        private readonly IOpenWeatherMapApiPathService _openWeatherMapApiPathService;
        private readonly IWeatherHttpClient _weatherHttpClient;
        private readonly ILogger _logger;

        public OpenWeatherMapWeatherGetterService(
            IOpenWeatherMapApiPathService openWeatherMapApiPathService,
            IWeatherHttpClient weatherHttpClient,
            ILogger logger)
        {
            _openWeatherMapApiPathService = openWeatherMapApiPathService;
            _weatherHttpClient = weatherHttpClient;
            _logger = logger;
        }

        public async Task<WeatherDto> GetWeather(LocationDto location)
        {
            _logger.LogTrace($"Call method get weather by location coords");
            try
            {
                var httpCallPath = _openWeatherMapApiPathService.GetWeatherByGeoCoordinatesPath(location.Latitude, location.Longitude);
                _logger.LogTrace($"Method create to server {httpCallPath}");
                var responce = await _weatherHttpClient.GetAsJsonAsync(httpCallPath);

                return JsonConvert.DeserializeObject<WeatherDto>(responce);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Error in weather service API");
                throw;
            }
        }

        public async Task<WeatherDto> GetWeather(string cityName)
        {
            _logger.LogTrace($"Call method get weather by city name");
            try
            {
                var httpCallPath = _openWeatherMapApiPathService.GetWeatherByCityNamePath(cityName);
                _logger.LogTrace($"Method create to server {httpCallPath}");
                var responce = await _weatherHttpClient.GetAsJsonAsync(httpCallPath);

                return JsonConvert.DeserializeObject<WeatherDto>(responce);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Error in weather service API");
                throw;
            }
        }
    }
}
