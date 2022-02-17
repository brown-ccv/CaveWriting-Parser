using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Link")]
public class Link { 

	[XmlElement(ElementName="Enabled")] 
	public bool Enabled; 

	[XmlElement(ElementName="RemainEnabled")] 
	public bool RemainEnabled; 

	[XmlElement(ElementName="EnabledColor")] 
	public Color EnabledColor; 

	[XmlElement(ElementName="SelectedColor")] 
	public Color SelectedColor; 

	[XmlElement(ElementName="Actions")] 
	public Actions Actions; 
}
