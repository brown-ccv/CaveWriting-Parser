[XmlRoot(ElementName="Timeline")]
public class Timeline { 

	[XmlElement(ElementName="TimedActions")] 
	public List<TimedActions> TimedActions { get; set; } 

	[XmlAttribute(AttributeName="name")] 
	public string Name { get; set; } 

	[XmlAttribute(AttributeName="start-immediately")] 
	public bool StartImmediately { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}
