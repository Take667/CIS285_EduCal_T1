using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace EduCal
{
    public static class FileHelper
    {
        public static void SaveToFile<T>(string fileName, T data)
        {
            // Create an XmlSerializer for the specified type
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            // Create a StreamWriter to write the XML data to the file
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // Serialize the data to XML and write it to the file
                serializer.Serialize(writer, data);
            }
        }

        public static T LoadFromFile<T>(string fileName)
        {
            // Create an XmlSerializer for the specified type
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            // Create a StreamReader to read the XML data from the file
            using (StreamReader reader = new StreamReader(fileName))
            {
                // Deserialize the XML data to the specified type
                T data = (T)serializer.Deserialize(reader);
                return data;
            }
        }
    }
}
