using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="TimerChange")]
public class TimerChange { 

	[XmlElement(ElementName="start")] 
	public object Start; 

	[XmlAttribute(AttributeName="name")] 
	public string Name; 

	[XmlElement(ElementName="start_if_not_started")] 
	public object StartIfNotStarted; 

	[XmlElement(ElementName="stop")] 
	public object Stop; 
}
