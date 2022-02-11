using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Content")]
public class Content { 

	[XmlElement(ElementName="Text")] 
	public Text Text; 

	[XmlElement(ElementName="Image")] 
	public Image Image; 

	[XmlElement(ElementName="None")] 
	public object None; 

	[XmlElement(ElementName="ParticleSystem")] 
	public ParticleSystem ParticleSystem; 

	[XmlElement(ElementName="Light")] 
	public Light Light; 
}
