[XmlRoot(ElementName="Object")]
public class Object { 

	[XmlElement(ElementName="Visible")] 
	public bool Visible { get; set; } 

	[XmlElement(ElementName="Color")] 
	public double Color { get; set; } 

	[XmlElement(ElementName="Lighting")] 
	public bool Lighting { get; set; } 

	[XmlElement(ElementName="ClickThrough")] 
	public bool ClickThrough { get; set; } 

	[XmlElement(ElementName="AroundSelfAxis")] 
	public bool AroundSelfAxis { get; set; } 

	[XmlElement(ElementName="Scale")] 
	public DateTime Scale { get; set; } 

	[XmlElement(ElementName="Placement")] 
	public Placement Placement { get; set; } 

	[XmlElement(ElementName="Content")] 
	public Content Content { get; set; } 

	[XmlElement(ElementName="LinkRoot")] 
	public LinkRoot LinkRoot { get; set; } 

	[XmlAttribute(AttributeName="name")] 
	public string Name { get; set; } 

	[XmlText] 
	public string Text { get; set; } 

	[XmlElement(ElementName="SoundRef")] 
	public string SoundRef { get; set; } 
}
