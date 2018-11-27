using Weather.Domain.Entity;

namespace Weather.Domain.Interface.Service
{
    public interface IWeatherGetterService
    {
        WeaterDto GetWeater(LocationDto location);
    }
}
