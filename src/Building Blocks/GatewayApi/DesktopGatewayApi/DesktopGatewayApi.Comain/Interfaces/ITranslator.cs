using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopGatewayApi.Domain.Interfaces
{
    public interface ITranslator<in TSource, TDestination> : ITranslator
    {
        TDestination Translate(TSource source);
        void Update(TSource source, TDestination destination);
    }

    public interface ITranslator
    {
        void Configure();

        object Translate(object source);
        void Update(object source, object destination);

    }
