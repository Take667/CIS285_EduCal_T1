using EduCal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EduCal.EventForm;

namespace EduCal
{
    internal class EventDisplayFormcode
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; } // Nullable if applicable
        public string Location { get; set; }

        // New properties for event repetition
        public RecurrencePattern Recurrence { get; set; }

        // Color coordination properties
        public string Color { get; set; }

        // Categorization properties
        public List<string> Categories { get; set; } = new List<string>();

    }
}
