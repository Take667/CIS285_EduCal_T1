using System;
using System.Collections.Generic;

namespace EduCaldraft2
{
    internal class EventDisplayForm
    {
        private string v;
        private List<EventForm> eventsForDate;

        public EventDisplayForm(string v, List<EventForm> eventsForDate)
        {
            this.v = v;
            this.eventsForDate = eventsForDate;
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}