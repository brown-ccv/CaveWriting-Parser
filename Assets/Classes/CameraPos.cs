using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="CameraPos")]
public class CameraPos { 

	[XmlElement(ElementName="Placement")] 
	public Placement Placement; 

	[XmlAttribute(AttributeName="far-clip")] 
	public double FarClip; 

	[XmlText] 
	public string Text; 
}
