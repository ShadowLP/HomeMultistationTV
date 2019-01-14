using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopGatewayApi.Comain.Dto
{
    public class MainPageDto
    {
        WeatherDto Weather { get; set; }

        IList<WeatherDto> WeatherForecast { get; set; }

    }
}
