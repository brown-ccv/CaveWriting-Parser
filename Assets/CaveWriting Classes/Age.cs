[XmlRoot(ElementName="Age")]
public class Age { 

	[XmlAttribute(AttributeName="age")] 
	public int Age { get; set; } 

	[XmlAttribute(AttributeName="younger-than")] 
	public bool YoungerThan { get; set; } 
}
