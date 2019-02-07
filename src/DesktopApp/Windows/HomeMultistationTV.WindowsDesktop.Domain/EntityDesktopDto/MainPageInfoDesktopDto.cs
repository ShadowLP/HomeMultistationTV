using System.Collections.Generic;

namespace HomeMultistationTV.WindowsDesktop.Domain.EntityDesktopDto
{
    public class MainPageInfoDesktopDto
    {
        public WeatherInfoDesktopDto Weather { get; set; }

        public IList<WeatherInfoDesktopDto> WeatherForecast { get; set; }
    }
}
