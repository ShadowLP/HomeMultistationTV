using AutoMapper;
using DesktopGatewayApi.Comain.Dto;
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
            RegisterTranslator<WeatherDtoToMainDashboardDtoTranslator, WeatherDto, MainDashboardDto>(configurationExpression);
        }
    }
}
