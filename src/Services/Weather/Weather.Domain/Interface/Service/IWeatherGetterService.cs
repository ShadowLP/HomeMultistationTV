using System.Threading.Tasks;
using Weather.Domain.Entity;

namespace Weather.Domain.Interface.Service
{
    public interface IWeatherGetterService
    {
        Task<WeatherDto> GetWeather(LocationDto location);

        Task<WeatherDto> GetWeather(string cityName);
    }
}
