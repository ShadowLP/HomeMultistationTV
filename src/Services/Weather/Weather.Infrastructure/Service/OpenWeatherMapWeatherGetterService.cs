using Weather.Domain.Entity;
using Weather.Domain.Interface.Service;

namespace Weather.Infrastructure.Service
{
    public class OpenWeatherMapWeatherGetterService : IWeatherGetterService

    {
        public WeaterDto GetWeater(LocationDto location)
        {
            throw new System.NotImplementedException();
        }
    }
}
