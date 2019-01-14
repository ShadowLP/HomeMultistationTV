using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.CommonServiceLocator;
using Common.Domain;
using Common.Domain.Interfaces;
using CommonServiceLocator;
using DesktopGatewayApi.Domain.ApiServices;
using GatewayApi.Infrastructure.Services;
using GatewayApi.Infrastructure.Translator;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Weather.Infrastructure.Service;

namespace DesktopGatewayApi.Services
{
    public class AutofacInitializator
    {
        private readonly ContainerBuilder _builder;
        private readonly IConfigurationSection _config;

        public AutofacInitializator(IConfigurationSection config)
        {
            _builder = new ContainerBuilder();
            _config = config;
        }

        public IServiceProvider GetServiceContainer(IServiceCollection services)
        {
            SetTranslators();
            SetServices();
            _builder.Populate(services);

            var container = _builder.Build();
            var autofacServiceLocator = new AutofacServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => autofacServiceLocator);
            return new AutofacServiceProvider(container);
        }

        private void SetServices()
        {
            _builder.RegisterType<WeatherApiService>()
                .As<IWeatherApiService>()
                .SingleInstance();

            _builder.RegisterType<CommonHttpClient>()
                .As<IHttpClient>()
                .SingleInstance();
        }

        private void SetTranslators()
        {
            _builder.RegisterType<GateawayTranslatorFactory>()
                .As<ITranslatorFactory>()
                .SingleInstance();
        }
    }
}
