using GatewayApi.Domain.Interface;

namespace GatewayApi.Domain.Entity
{
    public class CommandResults : ICommandCommonResults
    {
        public ECommandResult Result { get; set; }
        public string Message { get; set; }
    }

    public class CommandResults<T> : ICommandDataResults<T>
    {
        public ECommandResult Result { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
