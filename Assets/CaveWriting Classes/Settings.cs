[XmlRoot(ElementName="Settings")]
public class Settings { 

	[XmlAttribute(AttributeName="freq")] 
	public double Freq { get; set; } 

	[XmlAttribute(AttributeName="volume")] 
	public double Volume { get; set; } 

	[XmlAttribute(AttributeName="pan")] 
	public double Pan { get; set; } 
}
