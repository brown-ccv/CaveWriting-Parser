[XmlRoot(ElementName="Text")]
public class Text { 

	[XmlElement(ElementName="text")] 
	public List<string> Text { get; set; } 

	[XmlAttribute(AttributeName="horiz-align")] 
	public string HorizAlign { get; set; } 

	[XmlAttribute(AttributeName="vert-align")] 
	public string VertAlign { get; set; } 

	[XmlAttribute(AttributeName="font")] 
	public string Font { get; set; } 

	[XmlAttribute(AttributeName="depth")] 
	public double Depth { get; set; } 
}
