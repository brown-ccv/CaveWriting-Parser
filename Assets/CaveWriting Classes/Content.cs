[XmlRoot(ElementName="Content")]
public class Content { 

	[XmlElement(ElementName="Text")] 
	public Text Text { get; set; } 

	[XmlElement(ElementName="Image")] 
	public Image Image { get; set; } 

	[XmlElement(ElementName="None")] 
	public object None { get; set; } 

	[XmlElement(ElementName="ParticleSystem")] 
	public ParticleSystem ParticleSystem { get; set; } 

	[XmlElement(ElementName="Light")] 
	public Light Light { get; set; } 
}
