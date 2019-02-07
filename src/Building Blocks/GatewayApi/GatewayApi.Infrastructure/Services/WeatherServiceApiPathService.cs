using DesktopGatewayApi.Domain.Interfaces;
using Microsoft.Extensions.Configuration;

namespace GatewayApi.Infrastructure.Services
{
    public class WeatherServiceApiPathService : IWeatherServiceApiPathService
    {
        private readonly IConfigurationSection _settings;

        public WeatherServiceApiPathService(IConfigurationSection settings)
        {
            _settings = settings;
        }

        public string getWeatherByCityName(string cityName)
        {
            return $"{_settings.GetValue<string>("ServiceWeatherCity")}{cityName}";
        }

        public string getWeatherByLocation(double log, double lan)
        {
            return $"{_settings.GetValue<string>("ServiceWeatherCoords")}/{log}/{lan}";
        }
    }
}
