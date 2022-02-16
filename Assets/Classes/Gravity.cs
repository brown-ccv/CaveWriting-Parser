using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Gravity")]
public class Gravity { 

	[XmlElement(ElementName="Direction")] 
	public Vector3 Direction; 
}
