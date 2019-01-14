using DesktopGatewayApi.Comain.Dto;
using GatewayApi.Domain.Interface;
using Microsoft.Extensions.Logging;

namespace DesktopGatewayApi.Command
{
    public class MainDashboardCommandFactory
    {
        private readonly ILogger _logger;

        public MainDashboardCommandFactory(
            ILogger logger)
        {
            _logger = logger;
        }

        public virtual IAsyncCommand<MainPageDto> GeGetMainPageDto(string cityName)
        {
            return new GetMainPageDtoCommand(cityName, _logger);
        }
    }
}
