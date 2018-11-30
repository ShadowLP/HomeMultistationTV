using System;
using System.Collections.Generic;
using System.Text;
using Weather.Infrastructure.Settings;
using Xunit;

namespace WeatherSerivceTest.WeatherInfrastructure
{
    public class WeatherApiConfigTest
    {
        private readonly WeatherApiConfigService _weatherApiConfigService;

        public WeatherApiConfigTest()
        {
        }

        [Fact]
        public void ConstructTest()
        {
            Assert.NotNull(_weatherApiConfigService);
        }
    }
}
