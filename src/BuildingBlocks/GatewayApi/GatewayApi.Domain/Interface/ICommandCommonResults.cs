using GatewayApi.Domain.Entity;

namespace GatewayApi.Domain.Interface
{
    public interface ICommandCommonResults
    {
        ECommandResult Result { get; set; }
        string Message { get; set; }
    }
}
