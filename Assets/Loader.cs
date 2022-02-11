using UnityEngine;
using System.IO;
using System.Xml.Serialization;

public class Loader : MonoBehaviour
{
    private void Start()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Story));
        StreamReader reader = new StreamReader(Application.dataPath + "/xml/run.xml");
        var story = (Story)serializer.Deserialize(reader);
        Debug.Log("Story: " + story);
    }
}