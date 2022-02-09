[XmlRoot(ElementName="Group")]
public class Group { 

	[XmlElement(ElementName="Objects")] 
	public List<Objects> Objects { get; set; } 

	[XmlAttribute(AttributeName="name")] 
	public string Name { get; set; } 
}
