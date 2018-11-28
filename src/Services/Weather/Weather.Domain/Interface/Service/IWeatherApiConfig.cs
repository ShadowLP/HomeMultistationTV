using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Domain.Interface.Service
{
    public interface IWeatherApiConfigService
    {
        string WeatherApiToken { get; }

        string GetWeatherURL { get; }
    }
}
