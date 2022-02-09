[XmlRoot(ElementName="RemoveCondition")]
public class RemoveCondition { 

	[XmlElement(ElementName="Position")] 
	public Position Position { get; set; } 

	[XmlElement(ElementName="Age")] 
	public Age Age { get; set; } 
}
