using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="OrbitPoint")]
public class OrbitPoint { 

	[XmlElement(ElementName="Center")] 
	public Vector3 Center; 

	[XmlElement(ElementName="Magnitude")] 
	public double Magnitude; 

	[XmlElement(ElementName="Epsilon")] 
	public double Epsilon; 

	[XmlElement(ElementName="Max_radius")] 
	public double MaxRadius; 
}
