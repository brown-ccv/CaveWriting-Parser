using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Gravity")]
public class Gravity { 

	[XmlAttribute(AttributeName="direction")] 
	public string Direction; 
}
