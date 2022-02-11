using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Mode")]
public class Mode { 

	[XmlElement(ElementName="Fixed")] 
	public object Fixed; 
}
