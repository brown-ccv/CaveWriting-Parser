[XmlRoot(ElementName="Source")]
public class Source { 

	[XmlElement(ElementName="ParticleDomain")] 
	public ParticleDomain ParticleDomain { get; set; } 

	[XmlAttribute(AttributeName="rate")] 
	public int Rate { get; set; } 
}
