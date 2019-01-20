using Common.Domain;
using Common.Domain.Interfaces;
using DesktopGatewayApi.Domain.Dto;
using DesktopGatewayApi.Domain.ApiServices;
using GatewayApi.Domain.Interface;
using Microsoft.Extensions.Logging;

namespace DesktopGatewayApi.Command
{
    public class MainDashboardCommandFactory
    {
        private readonly IWeatherApiService _weatherApiService;
        private readonly ITranslatorFactory _translatorFactory;
        private readonly ILogger<MainDashboardCommandFactory> _logger;

        public MainDashboardCommandFactory(
            IWeatherApiService weatherApiService,
            ITranslatorFactory translatorFactory,
            ILogger<MainDashboardCommandFactory> logger)
        {
            _weatherApiService = weatherApiService;
            _translatorFactory = translatorFactory;
            _logger = logger;
        }

        public virtual IAsyncCommand<MainDashboardDto> GeGetMainPageDto(string cityName)
        {
            return new GetMainPageDtoCommand(cityName, _weatherApiService, _translatorFactory, _logger);
        }
    }
}
