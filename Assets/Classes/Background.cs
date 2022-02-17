using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Background")]
public class Background { 

	[XmlAttribute(AttributeName="color")] 
	public string Color; 
}
