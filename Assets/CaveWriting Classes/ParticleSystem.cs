[XmlRoot(ElementName="ParticleSystem")]
public class ParticleSystem { 

	[XmlAttribute(AttributeName="max-particles")] 
	public int MaxParticles { get; set; } 

	[XmlAttribute(AttributeName="actions-name")] 
	public int ActionsName { get; set; } 

	[XmlAttribute(AttributeName="particle-group")] 
	public string ParticleGroup { get; set; } 

	[XmlAttribute(AttributeName="look-at-camera")] 
	public bool LookAtCamera { get; set; } 

	[XmlAttribute(AttributeName="sequential")] 
	public bool Sequential { get; set; } 

	[XmlAttribute(AttributeName="speed")] 
	public double Speed { get; set; } 
}
