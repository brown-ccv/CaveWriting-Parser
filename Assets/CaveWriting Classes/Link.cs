[XmlRoot(ElementName="Link")]
public class Link { 

	[XmlElement(ElementName="Enabled")] 
	public bool Enabled { get; set; } 

	[XmlElement(ElementName="RemainEnabled")] 
	public bool RemainEnabled { get; set; } 

	[XmlElement(ElementName="EnabledColor")] 
	public double EnabledColor { get; set; } 

	[XmlElement(ElementName="SelectedColor")] 
	public double SelectedColor { get; set; } 

	[XmlElement(ElementName="Actions")] 
	public Actions Actions { get; set; } 
}
