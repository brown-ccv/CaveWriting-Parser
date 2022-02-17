using UnityEngine;
using System;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json; // TEMP 
using System.Collections.Generic; // TEMP

public class Loader : MonoBehaviour
{
    private void Start()
    {

        XmlSerializer serializer = new XmlSerializer(
            typeof(Story), 
            new Type[] { typeof(Color32), typeof(Vector3), typeof(Vector2) }
        );

        // TEMP - Test serialization with Color32 and Vector3
        // {
        //     Story example = new Story();
        //     example.ObjectRoot = new List<Object>(){ new Object()};
        //     example.ObjectRoot[0].Name = "test object";
        //     example.ObjectRoot[0].Visible = true;
        //     example.ObjectRoot[0].Color = new Color32(127, 127, 127, 255);
        //     example.ObjectRoot[0].Lighting = false;
        //     example.ObjectRoot[0].ClickThrough = false;
        //     example.ObjectRoot[0].AroundSelfAxis = false;
        //     example.ObjectRoot[0].Scale = 2.5;
        //     example.ObjectRoot[0].Placement = new Placement();
        //     example.ObjectRoot[0].Placement.RelativeTo = "Center";
        //     example.ObjectRoot[0].Placement.Position = new Vector3(0.0f, 1.5f, -3.25f);
        //     example.ObjectRoot[0].Content = new Content();
        //     example.ObjectRoot[0].Content.Text = new Text();
        //     example.ObjectRoot[0].Content.Text.Content = "IF I TOLD HIM";
        //     example.ObjectRoot[0].Content.Text.HorizAlign = "center";
        //     example.ObjectRoot[0].Content.Text.VertAlign = "center";
        //     example.ObjectRoot[0].Content.Text.Font = "./fonts/Lucida.ttf";
        //     example.ObjectRoot[0].Content.Text.Depth = 15;
        //     PrintObject(example);

        //     Stream stream = File.Create(Application.dataPath + "/xml/run_test_write.xml");
        //     serializer.Serialize(stream, example);
        //     stream.Close();

        //     using (StreamReader reader = new StreamReader(Application.dataPath + "/xml/run_test_write.xml"))
        //     {
        //         PrintObject((Story)serializer.Deserialize(reader));
        //     }
        // }
        


        // Deserialize run.xml
        Story story;
        using (StreamReader reader = new StreamReader(Application.dataPath + "/xml/run_example.xml"))
        // using (StreamReader reader = new StreamReader(Application.dataPath + "/xml/run_original.xml"))
        {
            story = (Story)serializer.Deserialize(reader);
        }
        PrintObject(story);

        // Quit
        Application.Quit();
    }

    /********** HELPERS **********/

    private void PrintObject<T>(T obj) 
    {
        Debug.Log(JsonConvert.SerializeObject(
            obj, 
            Formatting.Indented,
            new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }
        ));
    }
}