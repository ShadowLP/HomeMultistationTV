using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Infrastructure.Exceptions
{
    public class WrongCityNameException: Exception
    {
        public WrongCityNameException(string message) => message = message;
    }
}
