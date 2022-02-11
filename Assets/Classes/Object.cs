using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Object")]
public class Object { 

	[XmlElement(ElementName="Visible")] 
	public bool Visible; 

	[XmlElement(ElementName="Color")] 
	public Color Color;

	[XmlElement(ElementName="Lighting")] 
	public bool Lighting; 

	[XmlElement(ElementName="ClickThrough")] 
	public bool ClickThrough; 

	[XmlElement(ElementName="AroundSelfAxis")] 
	public bool AroundSelfAxis; 

	[XmlElement(ElementName="Scale")] 
	public double Scale; 

	[XmlElement(ElementName="Placement")] 
	public Placement Placement; 

	[XmlElement(ElementName="Content")] 
	public Content Content; 

	[XmlElement(ElementName="LinkRoot")] 
	public LinkRoot LinkRoot; 

	[XmlAttribute(AttributeName="name")] 
	public string Name; 

	[XmlText] 
	public string Text; 

	[XmlElement(ElementName="SoundRef")] 
	public string SoundRef; 
}
