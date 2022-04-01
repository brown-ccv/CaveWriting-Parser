using UnityEngine;
using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(ElementName="Story")]
public class Story { 

	[XmlArray(ElementName="ObjectRoot")]
	[XmlArrayItem(ElementName="Object")] 
	public List<Object> ObjectRoot;

	[XmlArray(ElementName="GroupRoot")]
	[XmlArrayItem(ElementName="Group")] 
	public List<Group> GroupRoot;

	[XmlArray(ElementName="TimelineRoot")]
	[XmlArrayItem(ElementName="Timeline")]
	public List<Timeline> TimelineRoot;

	[XmlArray(ElementName="PlacementRoot")]
	[XmlArrayItem(ElementName="Placement")] 
	public List<Placement> PlacementRoot;

	[XmlArray(ElementName="SoundRoot")]
	[XmlArrayItem(ElementName="Sound")] 
	public List<Sound> SoundRoot;

	[XmlArray(ElementName="ParticleActionRoot")]
	[XmlArrayItem(ElementName="ParticleActionList")] 
	public List<ParticleAction> ParticleActionRoot;

	[XmlElement(ElementName="Global")] 
	public Global Global; 

	[XmlAttribute(AttributeName="version")] 
	public int Version; 

	[XmlAttribute(AttributeName="last_xpath")] 
	public string LastXpath; 

	[XmlText] 
	public string Text; 
}
