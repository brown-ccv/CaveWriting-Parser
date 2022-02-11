using UnityEngine;
using System.IO;
using System.Xml.Serialization;

public class Loader : MonoBehaviour
{
    private void Start()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Story));
        StreamReader reader = new StreamReader("./xml TEST/run.xml");
        var project = (Story)serializer.Deserialize(reader);
        Debug.Log(project);
    }
}