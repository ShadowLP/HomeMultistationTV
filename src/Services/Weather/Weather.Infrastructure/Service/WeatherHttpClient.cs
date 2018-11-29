using NLog;
using System.Net.Http;
using System.Threading.Tasks;
using Weather.Domain.Interface.Service;

namespace Weather.Infrastructure.Service
{
    public class WeatherHttpClient : IWeatherHttpClient
    {
        private readonly ILogger _logger;
        private HttpClient _httpClient;

        public WeatherHttpClient(ILogger logger)
        {
            _httpClient = new HttpClient();
            _logger = logger;
        }

        public async Task<string> GetAsJsonAsync(string requestUri)
        {
            _logger.Trace($"Creating Get as JSON async to {requestUri}");
            HttpResponseMessage responce = await _httpClient.GetAsync(requestUri);

           var result = await responce.Content.ReadAsStringAsync();

            _logger.Trace($"Get result as JSON async from {requestUri} - {result}");

            return result;
        }
    }
}
