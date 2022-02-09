[XmlRoot(ElementName="LookAt")]
public class LookAt { 

	[XmlAttribute(AttributeName="target")] 
	public string Target { get; set; } 

	[XmlAttribute(AttributeName="up")] 
	public string Up { get; set; } 
}
