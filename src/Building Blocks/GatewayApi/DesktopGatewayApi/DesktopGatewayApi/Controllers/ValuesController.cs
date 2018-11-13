using Microsoft.AspNetCore.Mvc;

namespace DesktopGatewayApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperatureController : ControllerBase
    {
        [HttpGet]
        public ActionResult<double> Get()
        {
            return 0.0;
        }
    }
}
