using System.IO;
using System.Xml.Serialization;

public class XMLOp
{
    // Write object to xml file
    public static void Serialize(object obj, string xmlPath)
    {
        XmlSerializer serializer = new XmlSerializer(obj.GetType());
        StreamWriter writer = new StreamWriter(xmlPath);
        serializer.Serialize(writer.BaseStream, obj);
        writer.Close();
    }

    // Read xml file into object
    public static T Deserialize<T>(string xmlPath)
    {
        try 
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (var stream = new FileStream(xmlPath, FileMode.Open))
            {
                T xml = (T)serializer.Deserialize(stream);
                return xml;
            }
        }
        catch (Exception e)
        {
            Debug.LogError("Exception importing xml file: " + e);
            return default;
        }
    }
}