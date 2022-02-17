using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Placement")]
public class Placement { 

	[XmlElement(ElementName="RelativeTo")] 
	public string RelativeTo; 

	[XmlElement(ElementName="Position")]
	public Vector3 Position;

	[XmlElement(ElementName="Axis")] 
	public Axis Axis; 

	[XmlAttribute(AttributeName="name")] 
	public string Name; 

	[XmlText] 
	public string Text; 

	[XmlElement(ElementName="LookAt")] 
	public LookAt LookAt; 
}
