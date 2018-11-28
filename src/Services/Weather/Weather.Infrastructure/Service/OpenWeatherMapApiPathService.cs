using Microsoft.Extensions.Configuration;
using System;
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
            return name;
        }

        public string GetWeatherByGeoCoordinatesPath(double lat, double lon)
        {
            throw new NotImplementedException();
        }

        public string GetWeatherByZipCodePath(string zipCode)
        {
            throw new NotImplementedException();
        }
    }
}
