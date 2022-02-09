[XmlRoot(ElementName="Bounce")]
public class Bounce { 

	[XmlElement(ElementName="ParticleDomain")] 
	public ParticleDomain ParticleDomain { get; set; } 

	[XmlAttribute(AttributeName="friction")] 
	public double Friction { get; set; } 

	[XmlAttribute(AttributeName="resilience")] 
	public double Resilience { get; set; } 

	[XmlAttribute(AttributeName="cutoff")] 
	public int Cutoff { get; set; } 
}
