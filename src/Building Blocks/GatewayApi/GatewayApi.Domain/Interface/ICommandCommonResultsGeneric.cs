namespace GatewayApi.Domain.Interface
{
    public interface ICommandDataResults<T> : ICommandCommonResults
    {
        T Data { get; set; }
    }
}
