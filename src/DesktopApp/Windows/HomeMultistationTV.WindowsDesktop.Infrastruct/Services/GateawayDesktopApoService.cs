using HomeMultistationTV.WindowsDesktop.Domain.Interfaces;
using Microsoft.Extensions.Configuration;

namespace HomeMultistationTV.WindowsDesktop.Infrastruct.Services
{
    public class GateawayDesktopApoService : IGateawayDesktopApiService
    {
        private readonly IConfigurationSection _configurationSettings;

        public GateawayDesktopApoService (IConfigurationSection configurationSettings)
        {
            _configurationSettings = configurationSettings;
        }

        public string getMainPageInfoPath()
        {
            return $"{_configurationSettings.GetValue<string>("GateawayApiMainPage")}";
        }
    }
}
