# CaveWriting-Parser

Parser for converting XML code from CaveWriting into a Unity project

I'm adding notes about the changes to the C# classes I'm making while I work through them. This is just in case I have to redo the conversion and thus these changes. Notes can be deleted (moved at the least) when we go to publish the finalized package.

## Namespaces

`using UnityEngine;` and `using System.Xml.Serialization;` must be pre-pended to every class for serialization to work. Running `add_namespaces.sh` as a bash script will do so - just be sure to comment out the correct lines of the script.

Any class using the `List` type must prepend `using System.Collections.Generic;`. These classes are `SoundRoot`, `ParticleActionRoot`, `GroupRoot`, `PlacementRoot`, `Group`, `ObjectRoot`, `Timeline`, `ParticleActionList`, `TimelineRoot`, and `Text`.

## Fixed types

The [XML to C# convertor](https://json2csharp.com/xml-to-csharp) used to generate the C# classes did not type all of the attributes correctly. Below is the exhaustive list of original types and what they've been corrected to:

| File              | Original          | Fixed             |
| ---------------   | ---------------   | ---------------   |
| Object.cs | `public DateTime Scale` | `public double Scale`
| Object.cs | `public double Color`   | `public Color Color`
| Transition.cs | `public bool Text`  | `public string Text`
| GroupRef.cs   | `public bool Text`  | `public string Text`
| ObjectChange.cs   | `public bool Text`  | `public string Text`
| TimedActions.cs   | `public bool Text`  | `public string Text`
| Link.cs   | `public double EnabledColor`    | `public Color EnabledColor`
| Link.cs   | `public double SelectedColor`   | `public Color SelectedColor`
| Transition.cs | `public int Duration` | `public double Duration`
| Text.cs | `public List<string> Content` | `public string Content`
| Axis.cs | `public string Rotation;`  | `public Vector3 Rotation;`
| ParticleSystem.cs | `public int ActionsName;` | `public string ActionsName;`
| Transition.cs | `public double Color;`    | `public Color Color;`
| ParticleActionList.cs | `public int Name;` | `public string Name;`

## Renamed fields

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
>    public string Content;
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
> }
> ```

Properties that are `Lists` of elements have `s` appended to their c# variable - the XML is untouched.

- `ObjectRoot.Object(s)`
- `GroupRoot.Group(s)`
- `ParticleActionList.ParticleAction(s)`
- `ParticleActionRoot.ParticleActionList(s)`
- `PlacementRoot.Placement(s)`
- `SoundRoot.Sound(s)`
- `TimelineRoot.Timeline(s)`

Here's an example using `ObjectRoot.Objects`:

> ```cs
>  [XmlElement(ElementName="Object")] 
>  public List<Object> Objects; 
>```

Note that [Timeline.TimedActions](#****) follows the same schema but other changes are made to the class

## Unity Special Types

C# variable types specific to Unity need to be arranged in a specific way in the XMl to be serialized correctly. This means the XML must be changed before being passed into the Unity parser. This is done in `translate.py` in the `CaveWriting Projects` repo.

### Color

The original XML holds 3 values (RGB) ranging from 0-255. Unity needs 4 values (RGBA) ranging from 0-1. The `<a>` value is always 1.

The changes are present for the following classes:

- `Object.Color`
- `Background.Color`
- `Link.EnabledColor`
- `Link.SelectedColor`
- `Transition.Color`

```xml
   <!-- Original -->
   <Color>255, 255, 255</Color>
   
   <!-- New -->
   <Color>
     <r>1</r>
     <g>1</g>
     <b>1</b>
     <a>1</a>
   </Color>
```

Note that [Global.Background](#global) also contains this color conversion but other changes were made to this conversion but other changes were made to the class.

### Vector3

The original xml contains 3 values inside parenthesis, Unity needs to specify the x, y , and z properties.

This change is made to `Placement.Position`. Note that their other other Vector3's in the program but [further changes](#xml-attributes-vs-elements) are needed.

```xml
   <!-- Original -->
   <Position>(0.0, 1.5, -3.25)</Position>
   
   <!-- New -->
   <Position>
      <x>0</x>
      <y>1.5</y>
      <z>-3.25</z>
   </Position>
```

### Xml Attributes vs Elements

Complex types cannot be stored as Xml attributes but some of the original Xml stores Unity types as Xml attributes. Fixing this requires changes to both the xml and C# class file. Note that ALL of the attributes of such a class  will be changed to elements, not just the complex type.

This change is needed for the following properties:

- `Axis.Rotation`
- `LookAt.Target`
- `LookAt.Up`
- `Gravity.Direction`
- `OrbitPoint.Center`  

Here's an example using the `Axis` class:

```xml
   <!-- Original -->
   <Axis rotation="(0.0, 1.0, 0.0)" angle="0.0"/>
   
   <!-- New -->
   <Axis>
      <Rotation>
         <x>0.0</x>
         <y>1.0</y>
         <z>0.0</z>
      </Rotation>
      <Angle>0.0</Angle>
   </Axis>
```

```cs
   // Original
   [XmlRoot(ElementName="Axis")]
   public class Axis { 

      [XmlAttribute(AttributeName="rotation")] 
      public string Rotation; 

      [XmlAttribute(AttributeName="angle")] 
      public double Angle; 
   }

   // New
   [XmlRoot(ElementName="Axis")]
   public class Axis { 

      [XmlElement(ElementName="Rotation")]
      public Vector3 Rotation;

      [XmlElement(AttributeName="angle")]
      public double Angle; 
}
```

## Discretionary Changes

I made (plan to make) some additional changes to the xml/c# files to make the code easier to read.

### TimedAction

TODO
`TimedActions` should be `TimedAction`

### GroupRoot.Group.ObjectRef

TODO
`GroupRoot.Group.Objects` should be `GroupRoot.Group.ObjectRefs` where `.ObjectRef` is a list of strings pointing to the `Object.name` property

## Sound

TODO

- Xml attributes of `Sound` should become Xml elements.
- Rename `Settings` as `SoundSettings`? Or just add everything as elements of sound?
- `Sound.Mode` should be an enum, `Sound.Repeat` a boolean.

### Particle Domain

TODO

- ParticleDomain should be an enum for the different possible types
- Each type (Line, Box, Cylinder, Disc, Plane, Sphere) uses xml attributes, need to be xml elements
- Vector3 conversions needed to be notes (currently strings)
- *Can I convert these to Unity objects directly?*

## Class Consolidation

### Global

TODO: Background becomes a property of Global and is of type Color. (Will be able to remove the Background class file)

## TODO

### Next Steps

1) [Xml changes for color types](#color)
2) [Global.Background.Color] change(#global)
3) [Xml changes for Vector3 types](#vector3)
4) [Xml changes for Vector3 types with attribute -> element conversions](#xml-attributes-vs-elements)
5) [TimedActions change](#timedaction)
6) [GroupRoot.Group.Objects change](#grouprootgroupobjectref)

### Stuff to Figure Out

- Is `<Transition>` always `MoveRel` - `Placement` - `<RelativeTo>Center</RelativeTo>`?
- Make an enumeration for the "center" and things like it? All sorts of xml tags point to this location type (`HorizAlign`, `VertAlign`, `RelativeTo`, etc.)
- All path names in the xml will need to replace `./` with `Application.dataPath + "/xml/"`
  - Do this in the python script in CaveWriting-Projects?
=======
Unity packaged used to parse CaveWriting files (XML) into a Unity projects
