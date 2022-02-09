[XmlRoot(ElementName="Story")]
public class Story { 

	[XmlElement(ElementName="ObjectRoot")] 
	public ObjectRoot ObjectRoot { get; set; } 

	[XmlElement(ElementName="GroupRoot")] 
	public GroupRoot GroupRoot { get; set; } 

	[XmlElement(ElementName="TimelineRoot")] 
	public TimelineRoot TimelineRoot { get; set; } 

	[XmlElement(ElementName="PlacementRoot")] 
	public PlacementRoot PlacementRoot { get; set; } 

	[XmlElement(ElementName="SoundRoot")] 
	public SoundRoot SoundRoot { get; set; } 

	[XmlElement(ElementName="ParticleActionRoot")] 
	public ParticleActionRoot ParticleActionRoot { get; set; } 

	[XmlElement(ElementName="Global")] 
	public Global Global { get; set; } 

	[XmlAttribute(AttributeName="version")] 
	public int Version { get; set; } 

	[XmlAttribute(AttributeName="last_xpath")] 
	public string LastXpath { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}
