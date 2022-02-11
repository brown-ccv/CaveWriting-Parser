using UnityEngine;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json; // TEMP

public class Loader : MonoBehaviour
{
    private void Start()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Story));
        Story story;

        // TEMP: Test types against full project
        using (StreamReader reader = new StreamReader(Application.dataPath + "/xml/run - Copy.xml"))
        // using (StreamReader reader = new StreamReader(Application.dataPath + "/xml/run.xml"))
        {
            story = (Story)serializer.Deserialize(reader);
        }
        Debug.Log("Story:");
        Debug.Log(JsonConvert.SerializeObject(
            story, 
            Formatting.Indented, 
            new JsonSerializerSettings()
                { 
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                }
        ));
    }
}