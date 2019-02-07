using AutoMapper;
using GatewayApi.Infrastructure.Translator;
using HomeMultistationTV.WindowsDesktop.Domain.EntityDesktopDto;
using HomeMultistationTV.WindowsDesktop.Infrastruct.PE;
using System;

namespace HomeMultistationTV.WindowsDesktop.Infrastruct.Translators
{
    public class DesktopTranslatorFactory : TranslatorFactory
    {
        public DesktopTranslatorFactory(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        protected override void RegisterTranslators(IMapperConfigurationExpression configurationExpression)
        {
            RegisterTranslator<WeatherDesktopDtoToWeatherPeTranslator, WeatherInfoDesktopDto, WeatherPe>(configurationExpression);
        }
    }
}
