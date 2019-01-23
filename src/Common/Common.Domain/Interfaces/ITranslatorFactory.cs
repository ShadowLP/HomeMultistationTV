using System;

namespace Common.Domain.Interfaces
{
    public interface ITranslatorFactory
    {
        ITranslator<TSource, TDestination> GetTranslator<TSource, TDestination>();
        ITranslator GetTranslator(Type sourceType, Type destinationType);
    }
}
