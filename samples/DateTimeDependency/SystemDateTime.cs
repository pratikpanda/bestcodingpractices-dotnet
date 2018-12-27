using System;
using System.Collections.Generic;
using System.Text;

namespace DateTimeDependency
{
    public class SystemDateTime : IDateTime
    {
        public DateTime Now
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}
