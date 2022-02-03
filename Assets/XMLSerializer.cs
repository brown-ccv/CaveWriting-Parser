using System.IO;
using System.Xml.Serialization;

public class XmlSerializer
{
    // Write item to xml file
	public static void Serialize(object item, string path)
	{
        // TODO: Use try/catch statement
		XmlSerializer serializer = new XmlSerializer(item.GetType());
		StreamWriter writer = new StreamWriter(path);
		serializer.Serialize(writer.BaseStream, item);
		writer.Close();
	}

    // Read object from xml file
	public static T Deserialize<T>(string path)
	{
        // TODO: Use try/catch statement
		XmlSerializer serializer = new XmlSerializer(typeof(T));
		StreamReader reader = new StreamReader(path);
		T deserialized = (T)serializer.Deserialize(reader.BaseStream);
		reader.Close();
        console.log("Read fle: ", deserialized);
		return deserialized;
	}
}