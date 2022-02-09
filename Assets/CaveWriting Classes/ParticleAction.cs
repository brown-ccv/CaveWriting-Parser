[XmlRoot(ElementName="ParticleAction")]
public class ParticleAction { 

	[XmlElement(ElementName="Gravity")] 
	public Gravity Gravity { get; set; } 

	[XmlElement(ElementName="Bounce")] 
	public Bounce Bounce { get; set; } 

	[XmlElement(ElementName="OrbitPoint")] 
	public OrbitPoint OrbitPoint { get; set; } 
}
