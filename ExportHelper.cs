using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace EduCal
{
    public static class ExportHelper
    {
        public static void ExportToICal(string fileName, string calendarData)
        {
            // Check if the file extension is '.ical', if not, append it
            if (!fileName.EndsWith(".ical", StringComparison.OrdinalIgnoreCase))
            {
                fileName += ".ical";
            }

            // Write calendar data to the specified file
            File.WriteAllText(fileName, calendarData, Encoding.UTF8);
        }
    }
}
