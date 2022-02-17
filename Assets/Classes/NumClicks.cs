using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="NumClicks")]
public class NumClicks { 

	[XmlAttribute(AttributeName="num_clicks")] 
	public int Count; 

	[XmlAttribute(AttributeName="reset")] 
	public bool Reset; 
}
