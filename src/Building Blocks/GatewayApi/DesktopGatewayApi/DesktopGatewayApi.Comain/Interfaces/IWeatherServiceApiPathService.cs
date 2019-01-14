namespace DesktopGatewayApi.Domain.Interfaces
{
    public interface IWeatherServiceApiPathService
    {
        string getWeatherByCityName(string cityName);

        string getWeatherByLocation(double log, double lan);
    }
}
