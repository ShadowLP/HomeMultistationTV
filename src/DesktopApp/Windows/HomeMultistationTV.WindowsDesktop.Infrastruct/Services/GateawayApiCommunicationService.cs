using Common.Domain;
using HomeMultistationTV.WindowsDesktop.Domain.EntityDesktopDto;
using HomeMultistationTV.WindowsDesktop.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeMultistationTV.WindowsDesktop.Infrastruct.Services
{
    public class GateawayApiCommunicationService : IGateawayApiCommunicationService
    {
        private readonly ILogger _logger;
        private readonly IGateawayDesktopApiService _gateawayDesktopApiService;
        private readonly IHttpClient _httpClient;

        public GateawayApiCommunicationService(
            IGateawayDesktopApiService gateawayDesktopApiService,
            IHttpClient httpClient,
            ILogger logger)
        {
            _logger = logger;
            this._gateawayDesktopApiService = gateawayDesktopApiService;
            _httpClient = httpClient;
        }

        public async Task<MainPageInfoDesktopDto> getMainPageInfo()
        {
            _logger.LogTrace($"Desktop app start request to get main page info");
            var stringObject = await _httpClient.GetAsJsonAsync(_gateawayDesktopApiService.getMainPageInfoPath());
            _logger.LogTrace($"Main page string object {stringObject}");
            var resultDto = JsonConvert.DeserializeObject<MainPageInfoDesktopDto>(stringObject);
            _logger.LogTrace($"Desktop app finish request to get main page info");

            return resultDto;
        }
    }
}
