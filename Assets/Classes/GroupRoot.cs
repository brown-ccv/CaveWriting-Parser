using UnityEngine;
using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(ElementName="GroupRoot")]
public class GroupRoot { 

	[XmlElement(ElementName="Group")] 
	public List<Group> Groups; 
}
