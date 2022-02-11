using UnityEngine;
using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(ElementName="TimelineRoot")]
public class TimelineRoot { 

	[XmlElement(ElementName="Timeline")] 
	public List<Timeline> Timeline; 
}
