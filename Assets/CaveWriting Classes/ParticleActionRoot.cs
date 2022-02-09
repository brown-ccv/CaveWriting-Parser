[XmlRoot(ElementName="ParticleActionRoot")]
public class ParticleActionRoot { 

	[XmlElement(ElementName="ParticleActionList")] 
	public List<ParticleActionList> ParticleActionList { get; set; } 
}
