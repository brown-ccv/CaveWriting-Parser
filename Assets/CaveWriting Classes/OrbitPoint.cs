[XmlRoot(ElementName="OrbitPoint")]
public class OrbitPoint { 

	[XmlAttribute(AttributeName="center")] 
	public string Center { get; set; } 

	[XmlAttribute(AttributeName="magnitude")] 
	public double Magnitude { get; set; } 

	[XmlAttribute(AttributeName="epsilon")] 
	public double Epsilon { get; set; } 

	[XmlAttribute(AttributeName="max_radius")] 
	public double MaxRadius { get; set; } 
}
