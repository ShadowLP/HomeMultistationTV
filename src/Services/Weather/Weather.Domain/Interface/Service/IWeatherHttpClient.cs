using System.Threading.Tasks;

namespace Weather.Domain.Interface.Service
{
    public interface IWeatherHttpClient 
    {
        Task<string> GetAsJsonAsync(string requestUri);
    }
}
