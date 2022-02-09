[XmlRoot(ElementName="ObjectChange")]
public class ObjectChange { 

	[XmlElement(ElementName="Transition")] 
	public Transition Transition { get; set; } 

	[XmlAttribute(AttributeName="name")] 
	public string Name { get; set; } 

	[XmlText] 
	public bool Text { get; set; } 
}
