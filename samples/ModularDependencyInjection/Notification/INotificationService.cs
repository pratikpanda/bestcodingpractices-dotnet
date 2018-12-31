using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModularDependencyInjection.Notification
{
    public interface INotificationService
    {
        Task Notify();
    }
}
