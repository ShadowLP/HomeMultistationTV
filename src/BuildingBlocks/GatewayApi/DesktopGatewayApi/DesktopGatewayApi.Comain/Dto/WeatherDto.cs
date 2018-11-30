using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopGatewayApi.Comain.Dto
{
    public class WeatherDto
    {
        public double Temperature { get; set; }

        public double Pressure { get; set; }

        public string Description { get; set; }

        public double WindSpeed { get; set; }
    }
}
