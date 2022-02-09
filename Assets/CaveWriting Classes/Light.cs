[XmlRoot(ElementName="Light")]
public class Light { 

	[XmlElement(ElementName="Point")] 
	public object Point { get; set; } 

	[XmlAttribute(AttributeName="diffuse")] 
	public bool Diffuse { get; set; } 

	[XmlAttribute(AttributeName="specular")] 
	public bool Specular { get; set; } 

	[XmlAttribute(AttributeName="const_atten")] 
	public double ConstAtten { get; set; } 

	[XmlAttribute(AttributeName="lin_atten")] 
	public double LinAtten { get; set; } 

	[XmlAttribute(AttributeName="quad_atten")] 
	public double QuadAtten { get; set; } 
}
