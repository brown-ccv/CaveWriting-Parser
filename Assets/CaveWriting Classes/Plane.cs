[XmlRoot(ElementName="Plane")]
public class Plane { 

	[XmlAttribute(AttributeName="point")] 
	public string Point { get; set; } 

	[XmlAttribute(AttributeName="normal")] 
	public string Normal { get; set; } 
}
