using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="LinkChange")]
public class LinkChange { 

	[XmlElement(ElementName="link_on")] 
	public object LinkOn; 

	[XmlElement(ElementName="link_off")] 
	public object LinkOff; 
}
