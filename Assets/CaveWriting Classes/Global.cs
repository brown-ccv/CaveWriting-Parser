[XmlRoot(ElementName="Global")]
public class Global { 

	[XmlElement(ElementName="CameraPos")] 
	public CameraPos CameraPos { get; set; } 

	[XmlElement(ElementName="CaveCameraPos")] 
	public CaveCameraPos CaveCameraPos { get; set; } 

	[XmlElement(ElementName="Background")] 
	public Background Background { get; set; } 

	[XmlElement(ElementName="WandNavigation")] 
	public WandNavigation WandNavigation { get; set; } 
}
