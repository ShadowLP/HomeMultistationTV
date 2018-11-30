using GatewayApi.Domain.Entity;
using GatewayApi.Domain.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace GatewayApi.Infrastructure.Command
{
    public abstract class AsyncCommand : IAsyncCommand
    {
        private readonly ILogger _logger;

        protected ILogger Logger
        {
            get { return _logger; }
        }

        protected AsyncCommand(ILogger logger)
        {
            _logger = logger;
        }

        public async Task<ICommandCommonResults> Execute()
        {
            var results = new CommandResults();
            try
            {
                await Run();
                results.Result = ECommandResult.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError("Command exception", ex);
                results.Result = ECommandResult.ServerFailedWithException;
                results.Message = ex.Message;
            }

            return results;
        }

        protected abstract Task Run();
    }

    public abstract class AsyncCommand<T> : IAsyncCommand<T>
    {
        private readonly ILogger _logger;

        protected AsyncCommand(ILogger logger)
        {
            _logger = logger;
        }

        public async Task<ICommandDataResults<T>> Execute()
        {
            var results = new CommandResults<T>();
            try
            {
                var data = await Run();
                results.Result = ECommandResult.Success;
                results.Data = data;
            }
            catch (Exception ex)
            {
                _logger.LogError("Command error", ex);
                results.Result = ECommandResult.ServerFailedWithException;
                results.Message = ex.Message;
            }

            return results;
        }

        protected abstract Task<T> Run();
    }
}
