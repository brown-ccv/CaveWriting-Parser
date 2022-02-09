[XmlRoot(ElementName="LinkChange")]
public class LinkChange { 

	[XmlElement(ElementName="link_on")] 
	public object LinkOn { get; set; } 

	[XmlElement(ElementName="link_off")] 
	public object LinkOff { get; set; } 
}
