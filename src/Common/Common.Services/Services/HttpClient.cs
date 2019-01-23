using Common.Domain;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Threading.Tasks;

namespace Weather.Infrastructure.Service
{
    public class CommonHttpClient : IHttpClient
    {
        private readonly ILogger<HttpClient> _logger;
        private System.Net.Http.HttpClient _httpClient;

        public CommonHttpClient(ILogger<HttpClient> logger)
        {
            _httpClient = new System.Net.Http.HttpClient();
            _logger = logger;
        }

        public async Task<string> GetAsJsonAsync(string requestUri)
        {
            _logger.LogTrace($"Creating Get as JSON async to {requestUri}");
            HttpResponseMessage responce = await _httpClient.GetAsync(requestUri);

           var result = await responce.Content.ReadAsStringAsync();

            _logger.LogTrace($"Get result as JSON async from {requestUri} - {result}");

            return result;
        }
    }
}
