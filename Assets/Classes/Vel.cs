using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Vel")]
public class Vel { 

	[XmlElement(ElementName="ParticleDomain")] 
	public ParticleDomain ParticleDomain; 
}
