using System;
using System.Collections.Generic;

namespace EduCal
{
    public static class EventManager
    {
        public static List<EventForm> EventsList { get; } = new List<EventForm>();

        public static void AddEvent(EventForm newEvent)
        {
            EventsList.Add(newEvent);
        }

        // Add other methods for managing events as needed
    }
}
