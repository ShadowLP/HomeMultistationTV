using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            return new AutofacServiceProvider(container);
        }

        private void SetServices()
        {
        }

        private void SetTranslators()
        {

        }
    }
}
