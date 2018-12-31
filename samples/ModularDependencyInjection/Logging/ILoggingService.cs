using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModularDependencyInjection.Logging
{
    public interface ILoggingService
    {
        Task Log();
    }
}
