[XmlRoot(ElementName="TimedActions")]
public class TimedActions { 

	[XmlElement(ElementName="GroupRef")] 
	public GroupRef GroupRef { get; set; } 

	[XmlAttribute(AttributeName="seconds-time")] 
	public double SecondsTime { get; set; } 

	[XmlText] 
	public bool Text { get; set; } 

	[XmlElement(ElementName="TimerChange")] 
	public TimerChange TimerChange { get; set; } 

	[XmlElement(ElementName="SoundRef")] 
	public SoundRef SoundRef { get; set; } 

	[XmlElement(ElementName="ObjectChange")] 
	public ObjectChange ObjectChange { get; set; } 

	[XmlElement(ElementName="MoveCave")] 
	public MoveCave MoveCave { get; set; } 
}
