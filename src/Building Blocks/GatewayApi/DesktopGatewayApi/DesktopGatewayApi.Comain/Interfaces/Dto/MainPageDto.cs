using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopGatewayApi.Domain.Dto
{
    public class MainDashboardDto
    {
        public MainDashboardDto()
        {
            Weather = new WeatherDto();
            WeatherForecast = new List<WeatherDto>();
        }

        public WeatherDto Weather { get; set; }

        public IList<WeatherDto> WeatherForecast { get; set; }

    }
}
