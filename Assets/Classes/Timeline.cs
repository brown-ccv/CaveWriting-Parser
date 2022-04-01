using UnityEngine;
using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(ElementName="Timeline")]
public class Timeline { 

	[XmlElement(ElementName="TimedAction")]
	public List<TimedAction> TimedActions; 

	[XmlAttribute(AttributeName="name")] 
	public string Name; 

	[XmlAttribute(AttributeName="start-immediately")] 
	public bool StartImmediately; 

	[XmlText] 
	public string Text; 
}
