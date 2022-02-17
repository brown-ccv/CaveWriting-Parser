using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Actions")]
public class Actions { 

	[XmlElement(ElementName="TimerChange")] 
	public TimerChange TimerChange; 

	[XmlElement(ElementName="Clicks")] 
	public Clicks Clicks; 
}
