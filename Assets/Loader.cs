using UnityEngine;

public class Loader : MonoBehaviour
{
    private void Start()
    {
        var test = XmlSerializer.Deserialize("./xml TEST/run.xml");
        Debug.Log(test);
    }
}