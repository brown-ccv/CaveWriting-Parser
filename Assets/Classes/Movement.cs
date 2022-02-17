using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Movement")]
public class Movement { 

	[XmlElement(ElementName="Placement")] 
	public Placement Placement; 
}
