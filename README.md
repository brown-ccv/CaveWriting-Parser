# CaveWriting-Parser

Parser for converting XML code from CaveWriting into a Unity project

## Notes on the C# Classes

I'm adding notes about the changes to the C# classes I'm making while I work through them. This is just in case I have to redo the conversion and thus these changes. Notes can be deleted (moved at the least) when we go to publish the finalized package.

### Namespaces

`using UnityEngine;` and `using System.Xml.Serialization;` must be pre-pended to every class for serialization to work. Running `add_namespaces.sh` as a bash script will do so - just be sure to comment out the correct lines of the script.

Any class using the `List` type must prepend `using System.Collections.Generic;`. These classes are `SoundRoot`, `ParticleActionRoot`, `GroupRoot`, `PlacementRoot`, `Group`, `ObjectRoot`, `Timeline`, `ParticleActionList`, `TimelineRoot`, and `Text`.

### Fixed types

The [XML to C# convertor](https://json2csharp.com/xml-to-csharp) used to generate the C# classes did not type all of the attributes correctly. Below is the exhaustive list of original types and what they've been corrected to

- In Object.cs: `public DateTime Scale` &rarr; `public int Scale`

### Renamed fields

The `age` attribute of `Age` is `Time` in c#

> ```xml
> <Age age="50" younger-than="false"/>
> ```
>
> ```cs
> [XmlRoot(ElementName="Age")]
> public class Age { 
> 
>     [XmlAttribute(AttributeName="age")] 
>     public int Time; 
> 
>     [XmlAttribute(AttributeName="younger-than")] 
>     public bool YoungerThan; 
> }
> ```

The `num_clicks` attribute of `NumClicks` is `Count` in c#

> ```xml
> <NumClicks num_clicks="1" reset="false"/>
> ```
>
> ```cs
> using UnityEngine;
> using System.Xml.Serialization;
> 
> [XmlRoot(ElementName="NumClicks")]
> public class NumClicks { 
> 
>     [XmlAttribute(AttributeName="num_clicks")] 
>     public int Count; 
>     
>     [XmlAttribute(AttributeName="reset")] 
>     public bool Reset; 
> }
> ```

The `text` element of `Text` is `Content` in c#:

> ```xml
> <Text horiz-align="center" vert-align="center" font="F:\\cavewriting_ike\\bin\\fonts\\Lucida.ttf" depth="0.0">
>     <text>X</text>
> </Text>
> ```
>
> ```cs
> [XmlRoot(ElementName="Text")]
> public class Text { 
> 
>    [XmlElement(ElementName="text")] 
>    public List<string> Content;
> 
>    [XmlAttribute(AttributeName="horiz-align")] 
>    public string HorizAlign; 
> 
>    [XmlAttribute(AttributeName="vert-align")] 
>    public string VertAlign; 
> 
>    [XmlAttribute(AttributeName="font")] 
>    public string Font; 
> 
>    [XmlAttribute(AttributeName="depth")] 
>    public double Depth; 
> 
> ```
