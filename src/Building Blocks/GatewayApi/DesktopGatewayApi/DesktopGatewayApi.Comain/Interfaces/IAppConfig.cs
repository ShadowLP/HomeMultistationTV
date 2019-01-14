namespace DesktopGatewayApi.Domain.Interfaces
{
    public interface IAppConfig
    {
        string GetServiceWeatherCity { get; }

        string GetServiceWeatherCoords { get; }

    }
}
