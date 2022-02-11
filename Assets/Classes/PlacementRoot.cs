using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="PlacementRoot")]
public class PlacementRoot { 

	[XmlElement(ElementName="Placement")] 
	public List<Placement> Placement; 
}
