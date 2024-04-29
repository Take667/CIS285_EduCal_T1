using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Json;

namespace EduCal
{
    internal class JSONfile
    {


public class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        // Add more properties as needed
    }

    class Program
    {
            public static object JsonConvert { get; private set; }

            static void Main(string[] args)
        {
            // Create an instance of your event
            Event myEvent = new Event
            {
                Name = "My Event",
                Date = DateTime.Now.AddDays(7),
                Location = "New York"
                // Set other properties as needed
            };

            // Convert event object to JSON
           

            // Specify the file path where you want to save the JSON file
            string filePath = "event.json";

            // Write JSON data to the file
            try
            {
                JSONFile.WriteAllText(filePath, eventJson);
                Console.WriteLine("Event saved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving event: {ex.Message}");
            }
        }
    }

}
}
