using Microsoft.Extensions.DependencyInjection;
using ModularDependencyInjection.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModularDependencyInjection.Modules
{
    public static class NotificationServiceCollectionExtensions
    {
        public static IServiceCollection AddNotificationComponents(this IServiceCollection services)
        {
            services.AddTransient<INotificationService, DebugNotificationService>();
            return services;
        }
    }
}
