[XmlRoot(ElementName="Sphere")]
public class Sphere { 

	[XmlAttribute(AttributeName="center")] 
	public string Center { get; set; } 

	[XmlAttribute(AttributeName="radius")] 
	public int Radius { get; set; } 

	[XmlAttribute(AttributeName="radius-inner")] 
	public double RadiusInner { get; set; } 
}
