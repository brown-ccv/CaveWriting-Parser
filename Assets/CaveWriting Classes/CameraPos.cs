[XmlRoot(ElementName="CameraPos")]
public class CameraPos { 

	[XmlElement(ElementName="Placement")] 
	public Placement Placement { get; set; } 

	[XmlAttribute(AttributeName="far-clip")] 
	public double FarClip { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}
