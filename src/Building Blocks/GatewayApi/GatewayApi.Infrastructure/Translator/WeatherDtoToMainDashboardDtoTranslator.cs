using AutoMapper;
using Common.Services.Translator;
using DesktopGatewayApi.Comain.Dto;
using System;

namespace GatewayApi.Infrastructure.Translator
{
    public class WeatherDtoToMainDashboardDtoTranslator : AutomapperTranslator<WeatherDto, MainDashboardDto>
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
                .ForMember(m => m.Weather.Description,  o => o.MapFrom(m => m.Description))
                .ForMember(m => m.Weather.Pressure,     o => o.MapFrom(m => m.Pressure))
                .ForMember(m => m.Weather.Temperature,  o => o.MapFrom(m => m.Temperature))
                .ForMember(m => m.Weather.WindSpeed,    o => o.MapFrom(m => m.WindSpeed));
        }
    }
}
