[XmlRoot(ElementName="ParticleDomain")]
public class ParticleDomain { 

	[XmlElement(ElementName="Line")] 
	public Line Line { get; set; } 

	[XmlElement(ElementName="Cylinder")] 
	public Cylinder Cylinder { get; set; } 

	[XmlElement(ElementName="Disc")] 
	public Disc Disc { get; set; } 

	[XmlElement(ElementName="Plane")] 
	public Plane Plane { get; set; } 

	[XmlElement(ElementName="Sphere")] 
	public Sphere Sphere { get; set; } 

	[XmlElement(ElementName="Box")] 
	public Box Box { get; set; } 
}
