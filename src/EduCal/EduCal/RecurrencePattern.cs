using System;
using System.Collections.Generic;
using static EduCal.EventForm;

namespace EduCal
{
    public class RecurrencePattern
    {
        public RecurrenceType Type { get; set; }
        public int OccurrenceCount { get; set; }
        public DateTime? EndDate { get; set; }
        public List<DayOfWeek> RepeatOnDays { get; set; }

        public RecurrencePattern()
        {
            RepeatOnDays = new List<DayOfWeek>();
        }
    }
}
