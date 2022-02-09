[XmlRoot(ElementName="Cylinder")]
public class Cylinder { 

	[XmlAttribute(AttributeName="p1")] 
	public string P1 { get; set; } 

	[XmlAttribute(AttributeName="p2")] 
	public string P2 { get; set; } 

	[XmlAttribute(AttributeName="radius")] 
	public double Radius { get; set; } 

	[XmlAttribute(AttributeName="radius-inner")] 
	public double RadiusInner { get; set; } 
}
