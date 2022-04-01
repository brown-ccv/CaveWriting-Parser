using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Global")]
public class Global { 

	[XmlElement(ElementName="CameraPos")] 
	public CameraPos CameraPos; 

	[XmlElement(ElementName="CaveCameraPos")] 
	public CaveCameraPos CaveCameraPos; 

	[XmlElement(ElementName="Background")] 
	public Color32 BackgroundColor; 

	[XmlElement(ElementName="WandNavigation")] 
	public WandNavigation WandNavigation; 
}
