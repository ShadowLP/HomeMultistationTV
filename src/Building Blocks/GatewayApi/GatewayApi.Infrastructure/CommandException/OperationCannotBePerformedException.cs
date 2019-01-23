using System;

namespace GatewayApi.Infrastructure.CommandException
{
    public class OperationCannotBePerformedException: Exception
    {
        public OperationCannotBePerformedException(string message):
            base(message)
        {
        }
    }
}
