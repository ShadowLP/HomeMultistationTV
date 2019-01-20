using AutoMapper;
using Common.Services.Translator;
using DesktopGatewayApi.Domain.Dto;
using System;

namespace GatewayApi.Infrastructure.Translator
{
    public class WeatherDtoToMainDashboardDtoTranslator : AutomapperTranslator<Weather.Communication.Entity.WeatherDto, WeatherDto>
    {
        public WeatherDtoToMainDashboardDtoTranslator(
            IMapperConfigurationExpression configurationExpression,
            Lazy<IMapper> mapper)
            : base(configurationExpression, mapper)
        {
        }

        public override void Configure()
        {
            base.Configure();

            Mapping
                .ForMember(m => m.Pressure,     o => o.MapFrom(m => m.Main.Pressure))
                .ForMember(m => m.Temperature,  o => o.MapFrom(m => m.Main.Temp))
                .ForMember(m => m.Humindity, o => o.MapFrom(m => m.Main.Humidity))
                .ForMember(m => m.WindSpeed,    o => o.MapFrom(m => m.Wind.Speed));
        }
    }
}
