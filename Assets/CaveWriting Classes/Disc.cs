[XmlRoot(ElementName="Disc")]
public class Disc { 

	[XmlAttribute(AttributeName="center")] 
	public string Center { get; set; } 

	[XmlAttribute(AttributeName="normal")] 
	public string Normal { get; set; } 

	[XmlAttribute(AttributeName="radius")] 
	public int Radius { get; set; } 

	[XmlAttribute(AttributeName="radius-inner")] 
	public double RadiusInner { get; set; } 
}
