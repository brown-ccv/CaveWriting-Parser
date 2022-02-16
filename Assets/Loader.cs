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
            new Type[] { typeof(Color), typeof(Vector3), typeof(Vector2) }
        );

        // TEMP - Test serialization with Color and Vector3
        // {
        //     Story example = new Story();
        //     example.ObjectRoot = new ObjectRoot();
        //     example.ObjectRoot.Objects = new List<Object>(){ new Object()};
        //     example.ObjectRoot.Objects[0].Name = "test object";
        //     example.ObjectRoot.Objects[0].Visible = true;
        //     example.ObjectRoot.Objects[0].Color = Color.white;
        //     example.ObjectRoot.Objects[0].Lighting = false;
        //     example.ObjectRoot.Objects[0].ClickThrough = false;
        //     example.ObjectRoot.Objects[0].AroundSelfAxis = false;
        //     example.ObjectRoot.Objects[0].Scale = 2.5;
        //     example.ObjectRoot.Objects[0].Placement = new Placement();
        //     example.ObjectRoot.Objects[0].Placement.RelativeTo = "Center";
        //     example.ObjectRoot.Objects[0].Placement.Position = new Vector3(0.0f, 1.5f, -3.25f);
        //     example.ObjectRoot.Objects[0].Content = new Content();
        //     example.ObjectRoot.Objects[0].Content.Text = new Text();
        //     example.ObjectRoot.Objects[0].Content.Text.Content = "IF I TOLD HIM";
        //     example.ObjectRoot.Objects[0].Content.Text.HorizAlign = "center";
        //     example.ObjectRoot.Objects[0].Content.Text.VertAlign = "center";
        //     example.ObjectRoot.Objects[0].Content.Text.Font = "./fonts/Lucida.ttf";
        //     example.ObjectRoot.Objects[0].Content.Text.Depth = 15;
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
        using (StreamReader reader = new StreamReader(Application.dataPath + "/xml/run_example_original.xml"))
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