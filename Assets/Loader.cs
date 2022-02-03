using UnityEngine;
public class Loader : MonoBehaviour
{
    private void Start()
    {
        Story story = XmlSerializer.Deserialize("./Visualizing_Rafson_Schwartz_Spr15/run.xml");
        Debug.Log(story);
    }
}