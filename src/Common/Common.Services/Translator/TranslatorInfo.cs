using Common.Domain.Interfaces;
using System;

namespace GatewayApi.Infrastructure.Translator
{
    class TranslatorInfo
    {
        public Type SourceType { get; set; }
        public Type DestinationType { get; set; }
        public ITranslator Translator { get; set; }
    }
}
