using UnityEngine;

public class Loader : MonoBehaviour
{
    private void Start()
    {
        T scene = Xml.Deserialize<Hero>("./Visualizing_Rafson_Schwartz_Spr15/run.xml");
        Debug.Log(scene);
    }
}