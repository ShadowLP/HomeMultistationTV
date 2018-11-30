using DesktopGatewayApi.Comain.Dto;
using GatewayApi.Infrastructure.Command;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace DesktopGatewayApi.Command
{
    public class GetMainPageDtoCommand : AsyncCommand<MainPageDto>
    {
        public GetMainPageDtoCommand(
            string cityName,
            ILogger logger) 
            : base(logger)
        {
        }

        protected override Task<MainPageDto> Run()
        {
            return;
        }
    }
}
