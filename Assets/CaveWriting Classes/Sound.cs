[XmlRoot(ElementName="Sound")]
public class Sound { 

	[XmlAttribute(AttributeName="action")] 
	public string Action { get; set; } 

	[XmlElement(ElementName="Mode")] 
	public Mode Mode { get; set; } 

	[XmlElement(ElementName="Repeat")] 
	public Repeat Repeat { get; set; } 

	[XmlElement(ElementName="Settings")] 
	public Settings Settings { get; set; } 

	[XmlAttribute(AttributeName="name")] 
	public string Name { get; set; } 

	[XmlAttribute(AttributeName="filename")] 
	public string Filename { get; set; } 

	[XmlAttribute(AttributeName="autostart")] 
	public bool Autostart { get; set; } 
}
