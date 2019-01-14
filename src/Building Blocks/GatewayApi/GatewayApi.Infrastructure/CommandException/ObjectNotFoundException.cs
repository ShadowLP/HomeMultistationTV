using System;

namespace GatewayApi.Infrastructure.CommandException
{
    public class ObjectNotFoundException: Exception
    {
        public ObjectNotFoundException(string message) 
            : base(message)
        {
        }
    }
}
