using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("dialogue")]
public class DialogueSettings
{
    [XmlElement("node")]
    public Node[] nodes;

    public static DialogueSettings Load(TextAsset _xml)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(DialogueSettings));
        StringReader reader = new StringReader(_xml.text);
        DialogueSettings dial = serializer.Deserialize(reader) as DialogueSettings;
        return dial;
    }
}

[SerializeField]
public class Node
{
    [XmlAttribute("text")]
    public string Text;

    [XmlAttribute("name")]
    public string Name;
}
