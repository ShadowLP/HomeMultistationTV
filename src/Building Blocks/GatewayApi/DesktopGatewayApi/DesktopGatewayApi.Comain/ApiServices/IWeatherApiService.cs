using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesktopGatewayApi.Domain.ApiServices
{
    public interface IWeatherApiService
    {
        Task<string> getWeatherByCity(string cityName);

        Task<string> getWeatherByCity(double lat, double lon);
    }
}
