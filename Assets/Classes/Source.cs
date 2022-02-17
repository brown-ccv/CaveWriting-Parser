using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Source")]
public class Source { 

	[XmlElement(ElementName="ParticleDomain")] 
	public ParticleDomain ParticleDomain; 

	[XmlAttribute(AttributeName="rate")] 
	public int Rate; 
}
