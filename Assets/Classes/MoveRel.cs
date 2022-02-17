using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="MoveRel")]
public class MoveRel { 

	[XmlElement(ElementName="Placement")] 
	public Placement Placement; 
}
