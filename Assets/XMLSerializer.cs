using System.IO;
using System.Xml.Serialization;

// TODO: Use try/catch clause
public class XmlSerializer
{
	// Write C# object to xml
    public static void Serialize(object item, string xmlPath)
    {
        XmlSerializer serializer = new XmlSerializer(item.GetType());
        StreamWriter writer = new StreamWriter(xmlPath);
        serializer.Serialize(writer.BaseStream, item);
        writer.Close();
    }

	// Read xml into C# object
    public static T Deserialize<T>(string xmlPath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        StreamReader reader = new StreamReader(xmlPath);
        T deserialized = (T)serializer.Deserialize(reader.BaseStream);
        reader.Close();
        return deserialized;
    }
}