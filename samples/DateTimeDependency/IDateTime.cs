using System;
using System.Collections.Generic;
using System.Text;

namespace DateTimeDependency
{
    public interface IDateTime
    {
        DateTime Now { get; }
    }
}
