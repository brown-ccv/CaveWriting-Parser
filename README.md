# CaveWriting-Parser

Unity package for converting XML code from CaveWriting projects into a Unity project

I'm adding notes about the changes to the C# classes I'm making while I work through them. This is just in case I have to redo the conversion and thus these changes. Notes can be deleted (moved at the least) when we go to publish the finalized package.

## Namespaces

`using UnityEngine;` and `using System.Xml.Serialization;` must be pre-pended to every class for serialization to work. Running `add_namespaces.sh` as a bash script will do so - just be sure to comment out the correct lines of the script.

Any class using the `List` type must prepend `using System.Collections.Generic;`. These classes are `SoundRoot`, `ParticleActionRoot`, `GroupRoot`, `PlacementRoot`, `Group`, `ObjectRoot`, `Timeline`, `ParticleActionList`, `TimelineRoot`, and `Text`.

## Fixed types

The [XML to C# convertor](https://json2csharp.com/xml-to-csharp) used to generate the C# classes did not type all of the attributes correctly. Below is the exhaustive list of original types and what they've been corrected to:

| File              | Original          | Fixed             |
| ---------------   | ---------------   | ---------------   |
| Object.cs | `public DateTime Scale` | `public double Scale`
| Object.cs | `public double Color`   | `public Color32 Color`
| Transition.cs | `public bool Text`  | `public string Text`
| GroupRef.cs   | `public bool Text`  | `public string Text`
| ObjectChange.cs   | `public bool Text`  | `public string Text`
| TimedActions.cs   | `public bool Text`  | `public string Text`
| Link.cs   | `public double EnabledColor`    | `public Color32 EnabledColor`
| Link.cs   | `public double SelectedColor`   | `public Color32 SelectedColor`
| Transition.cs | `public int Duration` | `public double Duration`
| Text.cs | `public List<string> Content` | `public string Content`
| Axis.cs | `public string Rotation;`  | `public Vector3 Rotation;`
| ParticleSystem.cs | `public int ActionsName;` | `public string ActionsName;`
| Transition.cs | `public double Color;`    | `public Color32 Color;`
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

- `Group.Ref(s)`
- `ParticleActionList.ParticleAction(s)`
- `Timeline.TimedActions`

Here's an example using `Group.ObjectRefs`:

> ```cs
>[XmlRoot(ElementName="Group")]
>public class Group { 
>
>  [XmlElement(ElementName="ObjectRef")]
>  public List<string> ObjectRefs; 
>
>  [XmlAttribute(AttributeName="name")] 
>  public string Name; 
>}
>```

Note that [Timeline.TimedActions](#timedaction) follows the same schema but other changes are made to the class.

## Unity Special Types

C# variable types specific to Unity need to be arranged in a specific way in the XMl to be serialized correctly. This means the XML must be changed before being passed into the Unity parser. This is done in `translate.py` in the `CaveWriting Projects` repo.

### Color

The original XML holds 3 values (RGB) ranging from 0-255. The Unity Color32 type needs 4 values (RGBA). We always set the alpha value to full (255).

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
     <r>255</r>
     <g>255</g>
     <b>255</b>
     <a>255</a>
   </Color>
```

Note that [Global.Background](#global) also contains this color conversion but other changes were made to this conversion but other changes were made to the class.

### Vector3

The original xml contains 3 values inside parenthesis, Unity needs to specify the x, y, and z properties.

This change is made to `Placement.Position`. Note that there are other Vector3's in the program but [further changes](#xml-attributes-vs-elements) are needed.

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

Complex types cannot be stored as Xml attributes but some of the original Xml stores Unity types as Xml attributes. Fixing this requires changes to both the xml and C# class file. Note that ALL of the attributes of such a class  will be changed to elements, not just the complex type, and that the element name is Capitalized.

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

      [XmlElement(ElementName="Angle")]
      public double Angle; 
}
```

## Discretionary Changes

I made (plan to make) some additional changes to the xml/c# files to make the code easier to read.

### TimedAction

The auto-generated class `TimedActions` has been renamed `TimedAction` and the file name updated accordingly. This is sort of the opposite problem as appending `s` to `<List>` type properties - the `s` belongs on the variable name, not the class itself. `Timeline.cs` uses the `TimedAction` class.

```cs
[XmlRoot(ElementName="Timeline")]
public class Timeline { 

   [XmlElement(ElementName="TimedAction")]
   public List<TimedAction> TimedActions; 

   /* ... */
}
```

### Sound

TODO:

- Xml attributes of `Sound` should become Xml elements.
- Rename `Settings` as `SoundSettings`? Or just add everything as elements of sound?
- `Sound.Mode` should be an enum, `Sound.Repeat` a boolean.

### Particle Domain

TODO:

- ParticleDomain should be an enum for the different possible types
- Each type (Line, Box, Cylinder, Disc, Plane, Sphere) uses xml attributes, need to be xml elements
- Vector3 conversions needed to be notes (currently strings)
- *Can I convert these to Unity objects directly?*

## Class Consolidation

### Story

The `GroupRoot`, `ObjectRoot`, `ParticleActionRoot`, `PlacementRoot`, `SoundRoot`, and `TimelineRoot` properties of the `Story` class are all classes with only one property - a list. These fields contain all of the groups, objects, etc., in the project. The lists have been consolidated into `Story.cs` and `*Root.cs` files have been deleted. Note the use of `[XmlArray]` abd `[XmlArrayItem]` to deserialize the data correctly.

```cs
[XmlRoot(ElementName="Story")]
public class Story { 

   // Before

   [XmlElement(ElementName="ObjectRoot")] 
   public ObjectRoot ObjectRoot; 

   [XmlElement(ElementName="GroupRoot")]
   public GroupRoot GroupRoot;

   [XmlElement(ElementName="TimelineRoot")] 
   public TimelineRoot TimelineRoot;

   [XmlElement(ElementName="PlacementRoot")] 
   public PlacementRoot PlacementRoot; 

   [XmlElement(ElementName="SoundRoot")] 
   public SoundRoot SoundRoot;

   [XmlElement(ElementName="ParticleActionRoot")] 
   public ParticleActionRoot ParticleActionRoot; 

   /* ... */

   // After

   [XmlArray(ElementName="ObjectRoot")]
   [XmlArrayItem(ElementName="Object")] 
   public List<Object> ObjectRoot

   [XmlArray(ElementName="GroupRoot")]
   [XmlArrayItem(ElementName="Group")] 
   public List<Group> GroupRoot

   [XmlArray(ElementName="TimelineRoot")]
   [XmlArrayItem(ElementName="Timeline")] 
   public List<Timeline> TimelineRoot

   [XmlArray(ElementName="PlacementRoot")]
   [XmlArrayItem(ElementName="Placement")] 
   public List<Placement> PlacementRoot

   [XmlArray(ElementName="SoundRoot")]
   [XmlArrayItem(ElementName="Sound")] 
   public List<Sound> SoundRoot

   [XmlArray(ElementName="ParticleActionRoot")]
   [XmlArrayItem(ElementName="ParticleActionList")] 
   public List<ParticleAction> ParticleActionRoot

   /* ... */
}

```

### LinkRoot

The `LinkRoot` class follows the same pattern as the other [`*Root` classes](#story) but is itself a property of the `Object` class. I decided to rename the property `Links` instead of `LinkRoot` because it's not a part of the `Story` class - that change is made in the xml file as well.

```cs
[XmlRoot(ElementName="Object")]
public class Object { 

   // Before 
   [XmlElement(ElementName="LinkRoot")] 
   public LinkRoot LinkRoot; 

   /* ... */

   // After 

   [XmlArray(ElementName="Links")]
   [XmlArrayItem(ElementName="Link")]
   public List<Link> Links; 

   /* ... */
}
```

### Global

TODO: Background becomes a property of Global and is of type Color. (Will be able to remove the Background class file)
The `Global.Background` class only contains one attribute - it's color. The `Background` class has been deleted and `Global.Background` is a property of type `Color32`, renamed to `BackgroundColor`

```cs
[XmlRoot(ElementName="Global")]
public class Global { 
   /* ... */

   [XmlElement(ElementName="Background")] 
   public Color32 BackgroundColor;  

   /* ... */
}

```

### GroupRoot.Group.ObjectRef

The `Group.Objects` class has been deleted as it is just an XML element with a name attribute. The name attribute is translated as the inner text of `Objects`, and the tag has been renamed `ObjectRef`. The variable name has been updated as well, to `ObjectRefs`.

```xml
<!-- Original -->
<Group name="title">
       <ObjectRef name="start_button" />
       <ObjectRef name="A Completed Portrait of Picasso" />
</Group>

<!-- New -->
<Group name="title">
       <ObjectRef>start_button</ObjectRef>
       <ObjectRef>A Completed Portrait of Picasso</ObjectRef>
</Group>
```

```cs
[XmlRoot(ElementName="Group")]
public class Group { 

   // Original 
   [XmlElement(ElementName="Objects")]
   public List<Objects> Objects;

   // New
   [XmlElement(ElementName="ObjectRef")]
   public List<string> ObjectRefs;

   /* ... */
}
```

### SoundRef

The `SoundRef` class falls in the same position as the [ObjectRef](#grouprootgroupobjectref) class. The `name` attribute has become the inner text of each `SoundRef` tag, the `SoundRef` property is now of type `string`, and the `SoundRef` class has been deleted.

This change is present in `Object.SoundRef` and `TimedAction.SoundRef`.

## TODO

### Next Steps

1) GroupRef.Transition (pull out to other class, GroupRef is just a string)

### Stuff to Figure Out

- Is `<Transition>` always `MoveRel` - `Placement` - `<RelativeTo>Center</RelativeTo>`?
- Make an enumeration for the "center" and things like it? All sorts of xml tags point to this location type (`HorizAlign`, `VertAlign`, `RelativeTo`, etc.)
- All path names in the xml will need to replace `./` with `Application.dataPath + "/xml/"`
  - Do this in the python script in CaveWriting-Projects?

### Parking Lot

1) [Sound changes](#sound)
2) [ParticleDomain changes](#particle-domain)
3) TimerChange
