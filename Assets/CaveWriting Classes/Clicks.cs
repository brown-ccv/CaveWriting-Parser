[XmlRoot(ElementName="Clicks")]
public class Clicks { 

	[XmlElement(ElementName="NumClicks")] 
	public NumClicks NumClicks { get; set; } 

	[XmlElement(ElementName="Any")] 
	public object Any { get; set; } 
}
