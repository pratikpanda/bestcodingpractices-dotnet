using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ModularDependencyInjection.Notification
{
    public class DebugNotificationService : INotificationService
    {
        public Task Notify()
        {
            Debug.WriteLine("Sample Notification.");
            return Task.CompletedTask;
        }
    }
}
