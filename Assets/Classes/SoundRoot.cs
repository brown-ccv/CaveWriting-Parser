using UnityEngine;
using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(ElementName="SoundRoot")]
public class SoundRoot { 

	[XmlElement(ElementName="Sound")] 
	public List<Sound> Sound; 
}
