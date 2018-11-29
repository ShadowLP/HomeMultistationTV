using Microsoft.Extensions.Configuration;
using Weather.Infrastructure.Interface;

namespace Weather.Infrastructure.Service
{
    public class OpenWeatherMapApiPathService : IOpenWeatherMapApiPathService
    {
        private readonly IConfigurationSection _settings;

        public OpenWeatherMapApiPathService(IConfigurationSection settings)
        {
            _settings = settings;
        }

        public string GetWeatherByCityNamePath(string name)
        {
            return $"{_settings.GetValue<string>("GetWeatherURL")}?q=name";
        }

        public string GetWeatherByGeoCoordinatesPath(double lat, double lon)
        {
            return $"{_settings.GetValue<string>("GetWeatherURL")}?lat={lat}&lon={lon}";
        }

        public string GetWeatherByZipCodePath(string zipCode)
        {
            return $"{_settings.GetValue<string>("GetWeatherURL")}?zip={zipCode}";
        }
    }
}
