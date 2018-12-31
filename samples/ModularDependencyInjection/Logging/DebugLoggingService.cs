using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ModularDependencyInjection.Logging
{
    public class DebugLoggingService : ILoggingService
    {
        public Task Log()
        {
            Debug.WriteLine("Sample Log.");
            return Task.CompletedTask;
        }
    }
}
