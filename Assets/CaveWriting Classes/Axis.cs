[XmlRoot(ElementName="Axis")]
public class Axis { 

	[XmlAttribute(AttributeName="rotation")] 
	public string Rotation { get; set; } 

	[XmlAttribute(AttributeName="angle")] 
	public double Angle { get; set; } 
}
