using System;
using System.Collections.Generic;
using System.Text;

namespace HomeMultistationTV.WindowsDesktop.Infrastruct.PE
{
    public class MainPagePe
    {
        public MainPagePe()
        {
            Weather = new WeatherPe();
            WeatherForecast = new List<WeatherPe>();
        }

        public WeatherPe Weather { get; set; }

        public IList<WeatherPe> WeatherForecast { get; set; }
    }
}
