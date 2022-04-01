using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="LookAt")]
public class LookAt { 

	[XmlElement(ElementName="Target")] 
	public Vector3 Target; 

	[XmlElement(ElementName="Up")] 
	public Vector3 Up; 
}
