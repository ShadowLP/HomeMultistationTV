namespace Weather.Infrastructure.Interface
{
    public interface IOpenWeatherMapApiPathService
    {
        string GetWeatherByCityNamePath(string name);

        string GetWeatherByGeoCoordinatesPath(double lat, double lon);

        string GetWeatherByZipCodePath(string zipCode);         
    }
}
