using System.Threading.Tasks;

namespace GatewayApi.Domain.Interface
{
    public interface IAsyncCommand
    {
        Task<ICommandCommonResults> Execute();
    }

    public interface IAsyncCommand<T>
    {
        Task<ICommandDataResults<T>> Execute();
    }
}
