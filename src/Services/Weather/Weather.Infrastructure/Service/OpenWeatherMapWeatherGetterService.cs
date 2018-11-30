using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using Weather.Domain.Entity;
using Weather.Domain.Interface.Service;
using Weather.Infrastructure.Exceptions;
using Weather.Infrastructure.Interface;

namespace Weather.Infrastructure.Service
{
    public class OpenWeatherMapWeatherGetterService : IWeatherGetterService
    {
        private readonly IOpenWeatherMapApiPathService _openWeatherMapApiPathService;
        private readonly IWeatherHttpClient _weatherHttpClient;
        private readonly ILogger<OpenWeatherMapWeatherGetterService> _logger;

        public OpenWeatherMapWeatherGetterService(
            IOpenWeatherMapApiPathService openWeatherMapApiPathService,
            IWeatherHttpClient weatherHttpClient,
            ILogger<OpenWeatherMapWeatherGetterService> logger)
        {
            _openWeatherMapApiPathService = openWeatherMapApiPathService;
            _weatherHttpClient = weatherHttpClient;
            _logger = logger;
        }

        public async Task<WeatherDto> GetWeather(LocationDto location)
        {
            if (location == null 
                || (location.Latitude < -90 || location.Latitude > 90)
                || (location.Longitude > 180 || location.Longitude < 0))
            {
                var exception = new FormatException("Location in wrong formant");
                _logger.LogError("Location in wrong format", exception);
                throw exception;
            }

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
            if(string.IsNullOrEmpty(cityName))
            {
                var exception = new WrongCityNameException("City name cannot be null or empty");
                _logger.LogError("City name cannot be null or empty", exception);
                throw exception;
            }

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
