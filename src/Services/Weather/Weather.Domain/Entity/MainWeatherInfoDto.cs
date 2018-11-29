using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Domain.Entity
{
    public class MainWeatherInfoDto
    {
        public double Temp { get; set; }

        public double Humidity { get; set; }

        public double Pressure { get; set; }

        public double Temp_min { get; set; }

        public double Temp_max { get; set; }
    }
}
