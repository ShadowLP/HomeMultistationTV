using System;
using System.Collections.Generic;
using System.Text;
using Weather.Infrastructure.Interface;

namespace Weather.Infrastructure.Service
{
    public class OpenWeatherMapApiPathService : IOpenWeatherMapApiPathService
    {
        public string GetWeatherByCityNamePath(string name)
        {
            return ;
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
