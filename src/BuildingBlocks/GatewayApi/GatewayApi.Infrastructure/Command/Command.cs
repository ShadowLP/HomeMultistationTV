using GatewayApi.Domain.Entity;
using GatewayApi.Infrastructure.CommandException;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace GatewayApi.Infrastructure.Command
{
    public abstract class Command
    {
        private readonly ILogger<Command> _logger;

        protected ILogger<Command> Logger
        {
            get { return _logger; }
        }

        protected Command(ILogger<Command> logger)
        {
            _logger = logger;
        }

        public CommandResults Execute()
        {
            var results = new CommandResults();
            try
            {
                Run();
                results.Result = ECommandResult.Success;
            }
            catch (ObjectNotFoundException ex)
            {
                _logger.LogError("Object not found", ex);
                results.Result = ECommandResult.ObjectNotFound;
                results.Message = ex.Message;
            }
            catch (OperationCannotBePerformedException ex)
            {
                _logger.LogError("Operation cannot be perfomed", ex);
                results.Result = ECommandResult.OperationCanNotBePerformed;
                results.Message = ex.Message;
            }
            catch (Exception ex)
            {
                _logger.LogError("Command exception", ex);
                results.Result = ECommandResult.ServerFailedWithException;
                results.Message = ex.Message;
            }

            return results;
        }

        protected abstract void Run();
    }
}
