using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Image")]
public class Image { 

	[XmlAttribute(AttributeName="filename")] 
	public string Filename; 
}
