using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="TimelineRoot")]
public class TimelineRoot { 

	[XmlElement(ElementName="Timeline")] 
	public List<Timeline> Timeline; 
}
