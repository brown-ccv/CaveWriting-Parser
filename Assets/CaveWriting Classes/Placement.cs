[XmlRoot(ElementName="Placement")]
public class Placement { 

	[XmlElement(ElementName="RelativeTo")] 
	public string RelativeTo { get; set; } 

	[XmlElement(ElementName="Position")] 
	public string Position { get; set; } 

	[XmlElement(ElementName="Axis")] 
	public Axis Axis { get; set; } 

	[XmlAttribute(AttributeName="name")] 
	public string Name { get; set; } 

	[XmlText] 
	public string Text { get; set; } 

	[XmlElement(ElementName="LookAt")] 
	public LookAt LookAt { get; set; } 
}
