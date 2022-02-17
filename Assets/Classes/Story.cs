using UnityEngine;
using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(ElementName="Story")]
public class Story { 

	// [XmlElement(ElementName="ObjectRoot")] 
	// public ObjectRoot ObjectRoot; 
	[XmlArray(ElementName="ObjectRoot")]
	[XmlArrayItem(ElementName="Object")] 
	public List<Object> ObjectList;

	// [XmlElement(ElementName="GroupRoot")]
	// public GroupRoot GroupRoot;
	[XmlArray(ElementName="GroupRoot")]
	[XmlArrayItem(ElementName="Group")] 
	public List<Group> GroupList;

	// [XmlElement(ElementName="TimelineRoot")] 
	// public TimelineRoot TimelineRoot;
	[XmlArray(ElementName="TimelineRoot")]
	[XmlArrayItem(ElementName="Timeline")] 
	public List<Timeline> TimelineList;

	// [XmlElement(ElementName="PlacementRoot")] 
	// public PlacementRoot PlacementRoot; 
	[XmlArray(ElementName="PlacementRoot")]
	[XmlArrayItem(ElementName="Placement")] 
	public List<Placement> PlacementList;

	// [XmlElement(ElementName="SoundRoot")] 
	// public SoundRoot SoundRoot;
	[XmlArray(ElementName="SoundRoot")]
	[XmlArrayItem(ElementName="Sound")] 
	public List<Sound> SoundList;

	// [XmlElement(ElementName="ParticleActionRoot")] 
	// public ParticleActionRoot ParticleActionRoot; 
	[XmlArray(ElementName="ParticleActionRoot")]
	[XmlArrayItem(ElementName="ParticleActionList")] 
	public List<ParticleAction> ParticleActionList;

	[XmlElement(ElementName="Global")] 
	public Global Global; 

	[XmlAttribute(AttributeName="version")] 
	public int Version; 

	[XmlAttribute(AttributeName="last_xpath")] 
	public string LastXpath; 

	[XmlText] 
	public string Text; 
}
