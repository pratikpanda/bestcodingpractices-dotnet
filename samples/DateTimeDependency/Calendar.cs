using System;

namespace DateTimeDependency
{
    public class Calendar
    {
        private readonly IDateTime dateTime;

        public Calendar(IDateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public DayOfWeek GetDayOfWeek()
        {
            return dateTime.Now.DayOfWeek;
        }
    }
}
