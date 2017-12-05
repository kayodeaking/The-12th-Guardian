using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot("NPCCollection")]
public class NPCContainer {

	[XmlArray("NPCs")]
	[XmlArrayItem("NPC")]
	public List<NPC> nonPlayable = new List<NPC>();

	public static NPCContainer Load(string path) {
		TextAsset _xml = Resources.Load<TextAsset> (path);
		XmlSerializer serializer = new XmlSerializer (typeof(NPCContainer));
		StringReader reader = new StringReader (_xml.text);
		NPCContainer npcs = serializer.Deserialize (reader) as NPCContainer;
		reader.Close();
		return npcs;
	}
}
