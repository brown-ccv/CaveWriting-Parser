using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Age")]
public class Age { 

	[XmlAttribute(AttributeName="age")] 
	public int Time; 

	[XmlAttribute(AttributeName="younger-than")] 
	public bool YoungerThan; 
}
