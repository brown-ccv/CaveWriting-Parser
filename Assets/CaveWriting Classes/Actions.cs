[XmlRoot(ElementName="Actions")]
public class Actions { 

	[XmlElement(ElementName="TimerChange")] 
	public TimerChange TimerChange { get; set; } 

	[XmlElement(ElementName="Clicks")] 
	public Clicks Clicks { get; set; } 
}
