using DesktopGatewayApi.Comain.Dto;
using Microsoft.AspNetCore.Mvc;

namespace DesktopGatewayApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainDashboardController : ControllerBase
    {
        [HttpGet]
        public ActionResult<MainDashboardDto> GetMainInfo()
        {
            return null;
        }
    }
}
