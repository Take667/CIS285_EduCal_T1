using System.IO;
using System.Text.Json;

namespace EduCal
{
    public static class FileHelper
    {
        public static void SaveToFile(string fileName, object data)
        {
            string jsonString = JsonSerializer.Serialize(data);

            // Write the JSON string to a file
            File.WriteAllText(fileName, jsonString);
        }

        public static T LoadFromFile<T>(string fileName)
        {
            // Read the JSON string from the file
            string jsonString = File.ReadAllText(fileName);

            // Deserialize the JSON string to the specified type
            T data = JsonSerializer.Deserialize<T>(jsonString);

            return data;
        }
    }
}
