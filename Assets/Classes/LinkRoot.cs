using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="LinkRoot")]
public class LinkRoot { 

	[XmlElement(ElementName="Link")] 
	public Link Link; 
}
