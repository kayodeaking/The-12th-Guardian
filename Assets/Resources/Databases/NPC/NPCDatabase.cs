using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot("NPCDatabase")]
public class NPCDatabase
{

    [XmlArray("NPCs")]
    [XmlArrayItem("NPC")]
    public List<NPC> npcs = new List<NPC>();

    public static NPCDatabase Load(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);
        XmlSerializer serializer = new XmlSerializer(typeof(NPCDatabase));
        StringReader reader = new StringReader(_xml.text);
        NPCDatabase items = serializer.Deserialize(reader) as NPCDatabase;
        reader.Close();
        return items;
    }
}
