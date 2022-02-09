[XmlRoot(ElementName="TimerChange")]
public class TimerChange { 

	[XmlElement(ElementName="start")] 
	public object Start { get; set; } 

	[XmlAttribute(AttributeName="name")] 
	public string Name { get; set; } 

	[XmlElement(ElementName="start_if_not_started")] 
	public object StartIfNotStarted { get; set; } 

	[XmlElement(ElementName="stop")] 
	public object Stop { get; set; } 
}
