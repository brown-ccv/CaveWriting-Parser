using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Repeat")]
public class Repeat { 

	[XmlElement(ElementName="NoRepeat")] 
	public object NoRepeat; 
}
