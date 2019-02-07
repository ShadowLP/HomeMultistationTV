using System;
using AutoMapper;
using Common.Services.Translator;
using HomeMultistationTV.WindowsDesktop.Domain.EntityDesktopDto;
using HomeMultistationTV.WindowsDesktop.Infrastruct.PE;

namespace HomeMultistationTV.WindowsDesktop.Infrastruct.Translators
{
    public class MainPageDesktopDtoToMainPagePeTranslator : AutomapperTranslator<MainPageInfoDesktopDto, MainPagePe>
    {
        public MainPageDesktopDtoToMainPagePeTranslator(IMapperConfigurationExpression configurationExpression, Lazy<IMapper> mapper) 
            : base(configurationExpression, mapper)
        {
        }

        public override void Configure()
        {
            base.Configure();

            Mapping
                .ForMember(t => t.Weather, o => o.MapFrom(x => x.Weather))
                .ForMember(t => t.WeatherForecast, o => o.MapFrom(x => x.WeatherForecast));
        }
    }
}
