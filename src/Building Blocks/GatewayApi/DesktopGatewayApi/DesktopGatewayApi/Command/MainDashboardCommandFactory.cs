using Common.Domain;
using Common.Domain.Interfaces;
using DesktopGatewayApi.Comain.Dto;
using DesktopGatewayApi.Domain.ApiServices;
using GatewayApi.Domain.Interface;
using Microsoft.Extensions.Logging;

namespace DesktopGatewayApi.Command
{
    public class MainDashboardCommandFactory
    {
        private readonly IWeatherApiService _weatherApiService;
        private readonly ITranslator<WeatherDto, MainDashboardDto> _weatherDtoToMainDashboardDtoTranslator;
        private readonly ILogger _logger;

        public MainDashboardCommandFactory(
            IWeatherApiService weatherApiService,
            ITranslator<WeatherDto, MainDashboardDto> weatherDtoToMainDashboardDtoTranslator,
            ILogger logger)
        {
            _weatherApiService = weatherApiService;
            _weatherDtoToMainDashboardDtoTranslator = weatherDtoToMainDashboardDtoTranslator;
            _logger = logger;
        }

        public virtual IAsyncCommand<MainDashboardDto> GeGetMainPageDto(string cityName)
        {
            return new GetMainPageDtoCommand(cityName, _weatherApiService, _weatherDtoToMainDashboardDtoTranslator, _logger);
        }
    }
}
