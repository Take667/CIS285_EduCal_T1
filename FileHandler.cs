using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCaldraft2
{
    internal class FileHandler
    {
        
        public string FileName { get; set; }
        public static void SaveToFile(string content, int year)
        {
            string fileName = $"Calendar_{year}.txt";

            // Save to the application's directory
            File.WriteAllText(fileName, content);
        }
    }
}
    

