using DesktopGatewayApi.Domain.Interfaces;
using Microsoft.Extensions.Configuration;

namespace GatewayApi.Infrastructure.Services
{
    public class DesktopApiGatewayConfigService: IAppConfig
    {
        private readonly IConfigurationSection section;

        public DesktopApiGatewayConfigService(IConfigurationSection section)
        {
            this.section = section;
        }

        public string GetServiceWeatherCity
        {
            get
            {
                return section.GetSection("ServiceWeatherCity").Value;
            }
        }

        public string GetServiceWeatherCoords
        {
            get
            {
                return section.GetSection("ServiceWeatherCoords").Value;
            }
        }
    }
}
