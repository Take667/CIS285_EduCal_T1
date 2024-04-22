using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace EduCal
{
    public static class FileHelper
    {
        public static void SaveToFile<T>(string fileName, T data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, data);
            }
        }

        public static T LoadFromFile<T>(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StreamReader reader = new StreamReader(fileName))
            {
                T data = (T)serializer.Deserialize(reader);
                return data;
            }
        }
    }
}
