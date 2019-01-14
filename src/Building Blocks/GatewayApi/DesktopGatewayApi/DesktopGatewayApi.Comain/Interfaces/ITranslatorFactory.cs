using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopGatewayApi.Domain.Interfaces
{
    public interface ITranslatorFactory
    {
        ITranslator<TSource, TDestination> GetTranslator<TSource, TDestination>();
        ITranslator GetTranslator(Type sourceType, Type destinationType);
    }
}
