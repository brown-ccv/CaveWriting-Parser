[XmlRoot(ElementName="ParticleActionList")]
public class ParticleActionList { 

	[XmlElement(ElementName="Source")] 
	public Source Source { get; set; } 

	[XmlElement(ElementName="Vel")] 
	public Vel Vel { get; set; } 

	[XmlElement(ElementName="ParticleAction")] 
	public List<ParticleAction> ParticleAction { get; set; } 

	[XmlElement(ElementName="RemoveCondition")] 
	public RemoveCondition RemoveCondition { get; set; } 

	[XmlAttribute(AttributeName="name")] 
	public int Name { get; set; } 
}
