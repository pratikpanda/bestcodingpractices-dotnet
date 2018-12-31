using Microsoft.Extensions.DependencyInjection;
using ModularDependencyInjection.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModularDependencyInjection.Modules
{
    public static class LoggingServiceCollectionExtensions
    {
        public static IServiceCollection AddLoggingComponents(this IServiceCollection services)
        {
            services.AddTransient<ILoggingService, DebugLoggingService>();
            return services;
        }
    }
}
