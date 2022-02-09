[XmlRoot(ElementName="WandNavigation")]
public class WandNavigation { 

	[XmlAttribute(AttributeName="allow-rotation")] 
	public bool AllowRotation { get; set; } 

	[XmlAttribute(AttributeName="allow-movement")] 
	public bool AllowMovement { get; set; } 
}
