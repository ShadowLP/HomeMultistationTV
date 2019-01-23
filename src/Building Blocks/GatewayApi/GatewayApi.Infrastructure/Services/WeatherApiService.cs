using Common.Domain;
using DesktopGatewayApi.Domain.ApiServices;
using DesktopGatewayApi.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace GatewayApi.Infrastructure.Services
{
    public class WeatherApiService : IWeatherApiService
    {
        private readonly IWeatherServiceApiPathService _weatherServiceApiPathService;
        private readonly IHttpClient _httpClient;
        private readonly ILogger<WeatherApiService> _logger;

        public WeatherApiService(
            IWeatherServiceApiPathService weatherServiceApiPathService,
            IHttpClient httpClient,
            ILogger<WeatherApiService> logger)
        {
            _weatherServiceApiPathService = weatherServiceApiPathService;
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<string> getWeatherByCity(string cityName)
        {
            _logger.LogTrace($"Start get weatherByCity gateaway to weather api with {cityName}");

            var result = await _httpClient.GetAsJsonAsync(_weatherServiceApiPathService.getWeatherByCityName(cityName));

            _logger.LogTrace($"End get weatherByCity gateaway to weather api with {cityName}");
            return result;
        }

        public async Task<string> getWeatherByCity(double lat, double lon)
        {
            _logger.LogTrace($"Start get weatherByLocation gateaway to weather api with {lat} {lon}");

            var result = await _httpClient.GetAsJsonAsync(_weatherServiceApiPathService.getWeatherByLocation(lat, lon));

            _logger.LogTrace($"End get weatherByCity gateaway to weather api with {lat} {lon}");
            return result;
        }
    }
}
