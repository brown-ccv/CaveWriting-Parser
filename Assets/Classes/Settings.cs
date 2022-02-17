using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Settings")]
public class Settings { 

	[XmlAttribute(AttributeName="freq")] 
	public double Freq; 

	[XmlAttribute(AttributeName="volume")] 
	public double Volume; 

	[XmlAttribute(AttributeName="pan")] 
	public double Pan; 
}
