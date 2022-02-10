[XmlRoot(ElementName="Position")]
public class Position { 

	[XmlElement(ElementName="ParticleDomain")] 
	public ParticleDomain ParticleDomain; 

	[XmlAttribute(AttributeName="inside")] 
	public bool Inside; 
}
