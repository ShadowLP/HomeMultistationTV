using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Weather.Domain.Interface.Service;
using Weather.Infrastructure.Interface;
using Weather.Infrastructure.Service;

namespace Weather.API.Services
{
    public class AutofacInitializator
    {
        private readonly ContainerBuilder _builder;
        private readonly IConfigurationSection _settings;

        public AutofacInitializator(IConfigurationSection settings)
        {
            _builder = new ContainerBuilder();
            _settings = settings;
        }

        public IServiceProvider GetServiceContainer(IServiceCollection services)
        {
            SetTranslators();
            SetServices();
            _builder.Populate(services);

            var container = _builder.Build();
            return new AutofacServiceProvider(container);
        }

        private void SetServices()
        {
            _builder
                .RegisterType<OpenWeatherMapWeatherGetterService>()
                .As<IWeatherGetterService>()
                .SingleInstance();

            _builder
                .RegisterType<OpenWeatherMapApiPathService>()
                .As<IOpenWeatherMapApiPathService>()
                .WithParameter("setting", _settings);
        }

        private void SetTranslators()
        {

        }
    }
}
