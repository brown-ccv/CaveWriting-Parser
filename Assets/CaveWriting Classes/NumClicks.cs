[XmlRoot(ElementName="NumClicks")]
public class NumClicks { 

	[XmlAttribute(AttributeName="num_clicks")] 
	public int NumClicks { get; set; } 

	[XmlAttribute(AttributeName="reset")] 
	public bool Reset { get; set; } 
}
