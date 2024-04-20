using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCal
{
    internal class ExportCode
    {
       

public class Event
    {
        public string UID { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public static class ICalExporter
    {
        public static void ExportEvents(List<Event> events, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("BEGIN:VCALENDAR");
                writer.WriteLine("VERSION:2.0");
                writer.WriteLine("PRODID:-//My Event Calendar//EN");

                foreach (var ev in events)
                {
                    writer.WriteLine("BEGIN:VEVENT");
                    writer.WriteLine($"UID:{ev.UID}");
                    writer.WriteLine($"SUMMARY:{ev.Summary}");
                    writer.WriteLine($"DESCRIPTION:{ev.Description}");
                    writer.WriteLine($"DTSTART;VALUE=DATE:{ev.StartDate:yyyyMMdd}");
                    writer.WriteLine($"DTEND;VALUE=DATE:{ev.EndDate.AddDays(1):yyyyMMdd}"); // End date is exclusive, so add 1 day
                    writer.WriteLine("END:VEVENT");
                }

                writer.WriteLine("END:VCALENDAR");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Example events
            List<Event> events = new List<Event>
        {
            new Event
            {
                UID = Guid.NewGuid().ToString(),
                Summary = "Event 1",
                Description = "This is event 1",
                StartDate = new DateTime(2024, 4, 21),
                EndDate = new DateTime(2024, 4, 21)
            },
            new Event
            {
                UID = Guid.NewGuid().ToString(),
                Summary = "Event 2",
                Description = "This is event 2",
                StartDate = new DateTime(2024, 4, 22),
                EndDate = new DateTime(2024, 4, 22)
            }
        };

            // Export events to .ical file
            string fileName = "events.ical";
            string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
            ICalExporter.ExportEvents(events, savePath);

            Console.WriteLine($"Events exported to {savePath}");
        }
    }

}
}
