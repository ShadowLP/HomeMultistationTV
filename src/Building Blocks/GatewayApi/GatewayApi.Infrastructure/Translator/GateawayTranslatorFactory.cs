using AutoMapper;
using DesktopGatewayApi.Domain.Dto;
using System;

namespace GatewayApi.Infrastructure.Translator
{
    public class GateawayTranslatorFactory: TranslatorFactory
    {
        public GateawayTranslatorFactory(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        protected override void RegisterTranslators(IMapperConfigurationExpression configurationExpression)
        {
            RegisterTranslator<WeatherDtoToMainDashboardDtoTranslator, Weather.Communication.Entity.WeatherDto, WeatherDto>(configurationExpression);
        }
    }
}
