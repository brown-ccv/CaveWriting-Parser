using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="TimedActions")]
public class TimedAction { 

	[XmlElement(ElementName="GroupRef")] 
	public GroupRef GroupRef; 

	[XmlAttribute(AttributeName="seconds-time")] 
	public double SecondsTime; 

	[XmlText] 
	public string Text; 

	[XmlElement(ElementName="TimerChange")] 
	public TimerChange TimerChange; 

	[XmlElement(ElementName="SoundRef")] 
	public string SoundRef;

	[XmlElement(ElementName="ObjectChange")] 
	public ObjectChange ObjectChange; 

	[XmlElement(ElementName="MoveCave")] 
	public MoveCave MoveCave; 
}
