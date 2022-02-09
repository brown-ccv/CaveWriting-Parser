[XmlRoot(ElementName="MoveCave")]
public class MoveCave { 

	[XmlElement(ElementName="Relative")] 
	public object Relative { get; set; } 

	[XmlElement(ElementName="Placement")] 
	public Placement Placement { get; set; } 

	[XmlAttribute(AttributeName="duration")] 
	public double Duration { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}
