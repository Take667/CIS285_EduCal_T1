using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCal
{
    internal class EventList
    {
        private List<EventForm> GetEventsForDate(DateTime selectedDate, List<EventForm> eventsList)
        {
            List<EventForm> eventsForSelectedDay = new List<EventForm>();

            foreach (EventForm eventForm in eventsList)
            {
                // Check if the day of the month is the same
                if (eventForm.StartDate.Date.Day == selectedDate.Day)
                {
                    // TODO: Add any additional conditions if needed
                    eventsForSelectedDay.Add(eventForm);
                }
            }

            return eventsForSelectedDay;
        }
      
        
        private void InitializeForm(string date, List<EventForm> events)
        {
            throw new NotImplementedException();
        }

        // You might have an events list or similar data structure to store events
        private List<EventForm> eventsList = new List<EventForm>();

        // Method to add an event to the events list
        public void AddEventToList(EventForm newEvent)
        {
            eventsList.Add(newEvent);

            // Implement any additional logic you need
            // For example, update the UI to reflect the new event
        }
    }
}
