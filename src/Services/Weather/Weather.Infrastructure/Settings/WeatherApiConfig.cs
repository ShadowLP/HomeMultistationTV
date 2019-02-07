using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Weather.Domain.Interface.Service;

namespace Weather.Infrastructure.Settings
{
    public class WeatherApiConfigService: IWeatherApiConfigService
    {
        private readonly IConfigurationSection section;

        public WeatherApiConfigService(IConfigurationSection section)
        {
            this.section = section;
        }

        public string WeatherApiToken
        {
            get
            {
                return section.GetSection("WeatherApiToken").Value;
            }
        }

        public string GetWeatherURL
        {
            get
            {
                return section.GetSection("GetWeatherURL").Value;
            }
        }
    }
}
