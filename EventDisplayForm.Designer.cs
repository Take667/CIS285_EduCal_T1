using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EduCal
{
    public static class EduCal

    {
        static void Main()
        {

        }
        public static List<EventForm> EventsList { get; } = new List<EventForm>();
        public static object EventList { get; private set; }

        public static void AddEvent(EventForm newEvent)
        {
           
        }

        // Add other methods for managing events as needed
    }
}