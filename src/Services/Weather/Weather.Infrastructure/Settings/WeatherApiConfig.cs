using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Infrastructure.Settings
{
    public class WeatherApiConfig
    {
        public string WeatherApiToken { get; set; }

        public string GetWeatherURL { get; set; }
    }
}
