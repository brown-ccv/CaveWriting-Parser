using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Objects")]
public class Objects { 

	[XmlAttribute(AttributeName="name")] 
	public string Name; 
}
