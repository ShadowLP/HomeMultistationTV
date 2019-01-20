using Common.Domain;
using Common.Domain.Interfaces;
using DesktopGatewayApi.Comain.Dto;
using DesktopGatewayApi.Domain.ApiServices;
using GatewayApi.Infrastructure.Command;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace DesktopGatewayApi.Command
{
    public class GetMainPageDtoCommand : AsyncCommand<MainDashboardDto>
    {
        private readonly string _cityName;
        private readonly ITranslatorFactory _translatorFactory;

        private IWeatherApiService _weatherApiService { get; }

        public GetMainPageDtoCommand(
            string cityName,
            IWeatherApiService weatherApiService,
            ITranslatorFactory translatirFactory,
            ILogger logger) 
            : base(logger)
        {
            _cityName = cityName;
            _weatherApiService = weatherApiService;
            _translatorFactory = translatirFactory;
        }


        protected async override Task<MainDashboardDto> Run()
        {
            _logger.LogTrace("Start command GetMainPAgeDto {0}", _cityName);

            var test = JsonConvert.DeserializeObject<WeatherDto>(await _weatherApiService.getWeatherByCity(_cityName));

            _logger.LogDebug("Get object {0}", JsonConvert.SerializeObject(test));
            var mainDashboardDtoObject = new MainDashboardDto();

            _translatorFactory.GetTranslator<WeatherDto, MainDashboardDto>().Update(test, mainDashboardDtoObject);

            _logger.LogDebug("Get translated object object {0}", JsonConvert.SerializeObject(mainDashboardDtoObject));

            _logger.LogTrace("End command GetMainPAgeDto {0}", _cityName);

            return mainDashboardDtoObject;
        }
    }
}
