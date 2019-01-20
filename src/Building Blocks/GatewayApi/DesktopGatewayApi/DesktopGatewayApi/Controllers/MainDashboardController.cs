using DesktopGatewayApi.Comain.Dto;
using DesktopGatewayApi.Command;
using GatewayApi.Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DesktopGatewayApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainDashboardController : ControllerBase
    {
        private readonly MainDashboardCommandFactory _mainDashboardCommandFactory;

        public MainDashboardController(
            MainDashboardCommandFactory mainDashboardCommandFactory)
        {
            _mainDashboardCommandFactory = mainDashboardCommandFactory;
        }

        [HttpGet]
        [Route("city/{cityName}")]
        public Task<ICommandDataResults<MainDashboardDto>> GetMainInfo(string cityName)
        {
            return _mainDashboardCommandFactory.GeGetMainPageDto(cityName).Execute();
        }
    }
}
