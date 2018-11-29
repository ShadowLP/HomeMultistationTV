namespace Weather.Domain.Entity
{
    public class WeatherDto : EntityDto
    {
        public WeatherCooordDto Coord { get; set; }

        public SolarInfoDto Sys { get; set; }

        public CurrentWeatherDto Weather { get; set; }

        public MainWeatherInfoDto Main { get; set; }

        public WindInfoDto Wind { get; set; }

        public RainDto Rain { get; set; }

        public CloudsDto Clouds { get; set; }

        public long Dt { get; set; }

        public string Name { get; set; }

        public int Cod { get; set; }

    }
}
