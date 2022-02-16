using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Axis")]
public class Axis { 

	[XmlElement(ElementName="Rotation")] 
	public Vector3 Rotation; 

	[XmlElement(ElementName="Angle")] 
	public double Angle; 
}
