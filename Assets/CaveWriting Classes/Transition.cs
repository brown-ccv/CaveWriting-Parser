[XmlRoot(ElementName="Transition")]
public class Transition { 

	[XmlElement(ElementName="Visible")] 
	public bool Visible { get; set; } 

	[XmlAttribute(AttributeName="duration")] 
	public int Duration { get; set; } 

	[XmlText] 
	public bool Text { get; set; } 

	[XmlElement(ElementName="MoveRel")] 
	public MoveRel MoveRel { get; set; } 

	[XmlElement(ElementName="LinkChange")] 
	public LinkChange LinkChange { get; set; } 

	[XmlElement(ElementName="Scale")] 
	public double Scale { get; set; } 

	[XmlElement(ElementName="Movement")] 
	public Movement Movement { get; set; } 

	[XmlElement(ElementName="Sound")] 
	public Sound Sound { get; set; } 

	[XmlElement(ElementName="Color")] 
	public double Color { get; set; } 
}
