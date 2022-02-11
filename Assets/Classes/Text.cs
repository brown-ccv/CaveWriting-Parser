using UnityEngine;
using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(ElementName="Text")]
public class Text { 

	[XmlElement(ElementName="text")] 
	public string Content;

	[XmlAttribute(AttributeName="horiz-align")] 
	public string HorizAlign; 

	[XmlAttribute(AttributeName="vert-align")] 
	public string VertAlign; 

	[XmlAttribute(AttributeName="font")] 
	public string Font; 

	[XmlAttribute(AttributeName="depth")] 
	public double Depth; 
}
