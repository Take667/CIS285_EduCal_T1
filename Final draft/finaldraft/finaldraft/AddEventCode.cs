using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;


namespace EduCal
{
    internal class AddEventCode
    {

public class Event
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public string Color { get; set; }
        public List<string> Categories { get; set; }
        public Iteration Iteration { get; set; }
    }

    public class Iteration
    {
        public string Type { get; set; }
        public Repeat Repeat { get; set; }
    }

    public class Repeat
    {
        public int Interval { get; set; }
        public int OccurrenceCount { get; set; }
        public DateTime EndDate { get; set; }
        public List<int> DaysOfWeek { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Example event creation
            Event myEvent = new Event
            {
                Title = "Sample Event",
                Description = "This is a sample event.",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddHours(1),
                Location = "Sample Location",
                Color = "#FF0000", // Red color
                Categories = new List<string> { "Category1", "Category2" },
                Iteration = new Iteration
                {
                    Type = "once",
                    Repeat = new Repeat
                    {
                        Interval = 0,
                        OccurrenceCount = 0,
                        EndDate = DateTime.MinValue,
                        DaysOfWeek = new List<int>()
                    }
                }
            };

            // Display event details
            Console.WriteLine("Event Details:");
            Console.WriteLine($"Title: {myEvent.Title}");
            Console.WriteLine($"Description: {myEvent.Description}");
            Console.WriteLine($"Start Date: {myEvent.StartDate}");
            Console.WriteLine($"End Date: {myEvent.EndDate}");
            Console.WriteLine($"Location: {myEvent.Location}");
            Console.WriteLine($"Color: {myEvent.Color}");
            Console.WriteLine("Categories: " + string.Join(", ", myEvent.Categories));

            Console.WriteLine("\nIteration Details:");
            Console.WriteLine($"Type: {myEvent.Iteration.Type}");
            Console.WriteLine($"Interval: {myEvent.Iteration.Repeat.Interval}");
            Console.WriteLine($"Occurrence Count: {myEvent.Iteration.Repeat.OccurrenceCount}");
            Console.WriteLine($"End Date: {myEvent.Iteration.Repeat.EndDate}");
            Console.WriteLine("Days of Week: " + (myEvent.Iteration.Repeat.DaysOfWeek.Count > 0 ? string.Join(", ", myEvent.Iteration.Repeat.DaysOfWeek) : "N/A"));
        }
    }

}
}
