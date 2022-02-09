[XmlRoot(ElementName="Position")]
public class Position { 

	[XmlElement(ElementName="ParticleDomain")] 
	public ParticleDomain ParticleDomain { get; set; } 

	[XmlAttribute(AttributeName="inside")] 
	public bool Inside { get; set; } 
}
