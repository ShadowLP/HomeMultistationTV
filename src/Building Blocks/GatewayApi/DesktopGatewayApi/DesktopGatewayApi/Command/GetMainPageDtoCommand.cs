using Common.Domain;
using DesktopGatewayApi.Comain.Dto;
using DesktopGatewayApi.Domain.ApiServices;
using GatewayApi.Infrastructure.Command;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace DesktopGatewayApi.Command
{
    public class GetMainPageDtoCommand : AsyncCommand<MainPageDto>
    {
        private readonly IHttpClient _httpClient;
        private IWeatherApiService _weatherApiService { get; }

        public GetMainPageDtoCommand(
            string cityName,
            IHttpClient httpClient,
            IWeatherApiService weatherApiService,
            ILogger logger) 
            : base(logger)
        {
            _httpClient = httpClient;
            _weatherApiService = weatherApiService;
        }


        protected override Task<MainPageDto> Run()
        {
            var   _httpClient.GetAsJsonAsync(_weatherApiService.getWeatherApiServiceUri());
        }
    }
}
