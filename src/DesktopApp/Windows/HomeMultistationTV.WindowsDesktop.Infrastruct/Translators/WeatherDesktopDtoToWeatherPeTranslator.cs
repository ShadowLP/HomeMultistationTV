using System;
using AutoMapper;
using Common.Services.Translator;
using HomeMultistationTV.WindowsDesktop.Domain.EntityDesktopDto;
using HomeMultistationTV.WindowsDesktop.Infrastruct.PE;

namespace HomeMultistationTV.WindowsDesktop.Infrastruct.Translators
{
    public class WeatherDesktopDtoToWeatherPeTranslator : AutomapperTranslator<WeatherInfoDesktopDto, WeatherPe>
    {
        public WeatherDesktopDtoToWeatherPeTranslator(IMapperConfigurationExpression configurationExpression, Lazy<IMapper> mapper)
            : base(configurationExpression, mapper)
        {
        }

        public override void Configure()
        {
            base.Configure();

            Mapping
                .ForMember(t => t.Description, o => o.MapFrom(x => x.Description))
                .ForMember(t => t.Pressure, o => o.MapFrom(x => x.Pressure))
                .ForMember(t => t.Temperature, o => o.MapFrom(x => x.Temperature))
                .ForMember(t => t.WindSpeed, o => o.MapFrom(x => x.WindSpeed));
        }
    }
}
