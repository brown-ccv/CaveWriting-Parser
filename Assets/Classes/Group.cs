using UnityEngine;
using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(ElementName="Group")]
public class Group { 

	[XmlElement(ElementName="ObjectRef")]
	public List<string> ObjectRefs; 

	[XmlAttribute(AttributeName="name")] 
	public string Name; 
}
