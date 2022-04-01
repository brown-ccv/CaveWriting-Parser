using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Link")]
public class Link { 

	[XmlElement(ElementName="Enabled")] 
	public bool Enabled; 

	[XmlElement(ElementName="RemainEnabled")] 
	public bool RemainEnabled; 

	[XmlElement(ElementName="EnabledColor")] 
	public Color32 EnabledColor; 

	[XmlElement(ElementName="SelectedColor")] 
	public Color32 SelectedColor; 

	[XmlElement(ElementName="Actions")] 
	public Actions Actions; 
}
